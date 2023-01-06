using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using WpfOJT.App.Helpers;
using WpfOJT.App.ViewModels;
using WpfOJT.DAO.Helpers;
using WpfOJT.Entities.DTO;
using WpfOJT.Services.IServices;
using WpfOJT.Services.Services;
using OfficeOpenXml;
using System.IO;
using Microsoft.Win32;
using System.Linq;

namespace WpfOJT.App.Views.Post
{
    /// <summary>
    /// Define the <see cref="PostListViewModel"/>
    /// </summary>
    public class PostListViewModel
    {
        /// <summary>
        /// Define the Post
        /// </summary>
        public PostModel Post { get; set; }

        /// <summary>
        /// Define the userID
        /// </summary>
        private int userID = 0;

        /// <summary>
        /// Define the _postService
        /// </summary>
        private IPostService _postService;

        /// <summary>
        /// Constructor
        /// </summary>
        public PostListViewModel()
        {
            Post = new PostModel();
            _postService = new PostService();
            userID = (int)Application.Current.Properties["UserId"];
            GetAll("");
        }

        /// <summary>
        /// Constructor for Post Edit Page 
        /// </summary>
        /// <param name="id"></param>
        public PostListViewModel(int id)
        {
            Post = new PostModel();
            _postService = new PostService();
            userID = (int)Application.Current.Properties["UserId"];
            Get(id);
        }

        /// <summary>
        /// Define the _createPostCommand
        /// </summary>
        private ICommand _createCommand;

        /// <summary>
        /// Define the _saveCommand
        /// </summary>
        private ICommand _saveCommand;

        /// <summary>
        /// Define the _searchCommand
        /// </summary>
        private ICommand _searchCommand;

        /// <summary>
        /// Define the _cancelCommand
        /// </summary>
        private ICommand _cancelCommand;

        /// <summary>
        /// Define the _deleteCommand
        /// </summary>
        private ICommand _deleteCommand;

        /// <summary>
        /// Define the _downloadCommand
        /// </summary>
        private ICommand _downloadCommand;

        /// <summary>
        /// Define the DownloadCommand
        /// </summary>
        public ICommand DownloadCommand
        {
            get
            {
                if (_downloadCommand == null)
                {
                    _downloadCommand = new RelayCommand((param) => Download(),null);
                }
                return _downloadCommand;
            }
        }

        /// <summary>
        /// Define the DeleteCommand
        /// </summary>
        public ICommand DeleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                {
                    _deleteCommand = new RelayCommand((param) => Delete((int)param), null);
                }
                return _deleteCommand;
            }
            
        }

        /// <summary>
        /// Define the CancelCommand
        /// </summary>
        public ICommand CancelCommand
        {
            get
            {
                if (_cancelCommand == null)
                {
                    _cancelCommand = new RelayCommand((param) => Cancel(),null);
                }
                return _cancelCommand;
            }
        }

        /// <summary>
        /// Define the SearchCommand
        /// </summary>
        public ICommand SearchCommand
        {
            get
            {
                if (_searchCommand == null)
                {
                    _searchCommand = new RelayCommand((param) => Search((string)param), null);
                }
                return _searchCommand;
            }
            
        }

        /// <summary>
        /// Define the CreatePostCommand
        /// </summary>
        public ICommand CreateCommand
        {
            get
            {
                if (_createCommand == null)
                {
                    _createCommand = new RelayCommand((param) => New(), null);
                }
                return _createCommand;
            }
        }

        /// <summary>
        /// Define the SaveCommand
        /// </summary>
        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new RelayCommand((param) => Save(),null);
                }
                return _saveCommand;
            }
        }

        /// <summary>
        /// Search user lists
        /// </summary>
        /// <param name="keyword"></param>
        private void Search(string keyword)
        {
            GetAll(keyword);
        }

        /// <summary>
        /// Export post data into excel file
        /// </summary>
        public void Download()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Folders|\n";
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = true;
            if(openFileDialog.ShowDialog() == true)
            {
                string path = openFileDialog.FileName + ".xlsx";
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage())
                {
                    var model = _postService.GetAll(userID, "");
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Posts");
                    worksheet.Cells[1, 1].Value = "Title";
                    worksheet.Cells[1, 2].Value = "Description";
                    worksheet.Cells[1, 3].Value = "Status";
                    worksheet.Cells[1, 4].Value = "Created_Username";
                    worksheet.Cells[1, 6].Value = "Created_Date";
                    model.Posts.Select((post, index) => new { Index = index, Value = post }).ToList().ForEach(item =>
                    {
                        worksheet.Cells[item.Index + 2, 1].Value = item.Value.Title;
                        worksheet.Cells[item.Index + 2, 2].Value = item.Value.Description;
                        worksheet.Cells[item.Index + 2, 3].Value = item.Value.IsPublished ? "Published" : "Unpublished";
                        worksheet.Cells[item.Index + 2, 4].Value = item.Value.CreatedUserName;
                        worksheet.Cells[item.Index + 2, 6].Value = item.Value.sCreatedDate;
                    });
                    package.SaveAs(new FileInfo(path));
                    MessageBox.Show("Post data have been saved into selected file.");
                }
            }

        }



        /// <summary>
        /// Delete post
        /// </summary>
        /// <param name="id"></param>
        private void Delete(int id)
        {
            var result = MessageBoxHelper.confirmMessageBox(Message.DELETE_CONFIRM,Message.POST_TTL);
            if (result == MessageBoxResult.Yes)
            {
                ResponseModel responseModel = _postService.Delete(id, userID);
                if (responseModel.MessageType == Message.SUCCESS)
                {
                    MessageBoxHelper.showMessageBox(responseModel, Message.POST_TTL);
                    GetAll("");

                }
                else
                {
                    MessageBoxHelper.showMessageBox(responseModel, Message.POST_TTL);
                }
            }
        }

        /// <summary>
        /// Upload post data into database
        /// </summary>
        /// <param name="filePath"></param>
        public void Upload(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ResponseModel responseModel = new ResponseModel();
                PostViewModel postViewModel = new PostViewModel();
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rows =worksheet.Dimension.Rows;
                responseModel = _postService.Upload(rows,userID,worksheet);
                if (responseModel.MessageType == Message.SUCCESS)
                {
                    MessageBoxHelper.showMessageBox(responseModel,Message.POST_TTL);
                    GetAll("");
                }
                else
                {
                    MessageBoxHelper.showMessageBox(responseModel, Message.POST_TTL);
                }
            }
            
        }

        /// <summary>
        /// Get post by id
        /// </summary>
        /// <param name="id"></param>
        private void Get(int id)
        {
            var model = _postService.Get(id);
            Post.Id = model.Id;
            Post.Title = model.Title;
            Post.Description = model.Description;
            Post.IsPublished = model.IsPublished;
        }

        /// <summary>
        /// Retrieve post lists
        /// </summary>
        /// <param name="keyword"></param>
        private void GetAll(string keyword)
        {
            Post.Posts = new ObservableCollection<PostModel>();
            var model = _postService.GetAll(userID,keyword);
            model.Posts.ForEach(x => Post.Posts.Add(new PostModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Status = x.Status,
                CreatedAt = x.sCreatedDate,
                CreatedBy = x.CreatedUserName
            }));
        }

        /// <summary>
        /// Navigate to post list
        /// </summary>
        private void Cancel()
        {
            MainViewModel.Instance.PagePath = NavigationHelper.POST_LIST;
        }

        /// <summary>
        /// Navigate to post create
        /// </summary>
        private void New()
        {
            MainViewModel.Instance.PagePath = NavigationHelper.POST_CREATE;
        }

        /// <summary>
        /// Validate post inputs
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        private bool ValidateInput()
        {
            bool result = true;
            if (string.IsNullOrEmpty(Post.Title))
            {
                result = false;
                MessageBoxHelper.validateMessageBox(Message.TTL_REQUIRE,Message.POST_TTL);
            }
            else if (string.IsNullOrEmpty(Post.Description))
            {
                result = false;
                MessageBoxHelper.validateMessageBox(Message.DESCRIP_REQUIRE, Message.POST_TTL);
            }
            return result;
        }

        /// <summary>
        /// Save post
        /// </summary>
        private void Save()
        {
            try
            {
                if (Post != null)
                {
                    
                    bool isValid = ValidateInput();
                    if (isValid)
                    {
                        ResponseModel responseModel = new ResponseModel();
                        PostViewModel postViewModel = new PostViewModel();
                        postViewModel.Title = Post.Title;
                        postViewModel.Description = Post.Description;
                        postViewModel.IsPublished = Post.IsPublished;
                        if (Post.Id > 0)
                        {
                            postViewModel.Id = Post.Id;
                            postViewModel.UpdatedUserId = userID.ToString();
                            responseModel = _postService.Update(postViewModel);
                        }
                        else
                        {
                            postViewModel.CreatedDate = DateTime.Now;
                            postViewModel.CreatedUserId = userID.ToString();
                            responseModel = _postService.Save(postViewModel);
                        }


                        if (responseModel.MessageType == Message.SUCCESS)
                        {
                            MessageBoxHelper.showMessageBox(responseModel,Message.POST_TTL);
                            MainViewModel.Instance.PagePath = NavigationHelper.POST_LIST;
                        }
                        else
                        {
                            MessageBoxHelper.showMessageBox(responseModel, Message.POST_TTL);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


    }
}
