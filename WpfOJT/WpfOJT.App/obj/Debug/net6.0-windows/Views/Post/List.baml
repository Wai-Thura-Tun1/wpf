   M S B A M L   `   `   `  ????E  AWpfOJT.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfOJT.App.Views.PostWpfOJT.App.Views.Post  5           WpfOJT.App.Views.Post.List   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfOJT.App.Views.Post     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N? Title$
  List??5	      $??13(?5
         MaterialDesignBody#???   5      $??Regular"?5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5         TextRenderingMode$
 Auto=?5        MaterialDesignPaper N? 
Background# ?  5        MaterialDesignFont N? 
FontFamily# ?  5      .??5      ? .+?5   
   #  MaterialDesignThemes.Wpf.Card  $	??750??5      $??8q?5      .??5      ?? .+?5      ?  ? RowDefinitions 5      ?? 5      $??70 ?6(   ?? 5      $??40 ?6(    ? ColumnDefinitions 5      ?? 5      $	??160 ?6+   ?? 5      $??* ?6+   ?? 5      $	??120 ?6+   ?? 5      $	??180 ?6+   .+?5!      ?? $??	Post List??5"      $??25(?5#      $
??Bold"?5$      $??0??5%      $??0??5&      $??12,16,12,16q?5'      ?? 5(      $??0??6   $??3??5)      $??40??5*      $	??150??5+      $??0,0,10,0q?5,      $??Create New Post??5-      $??Right=?5.      
????  ???5/      ??  ?? Path$ CreateCommand?50      ?? 52      $??1??6    ! MaterialDesignOutlinedTextBox#??[ 53      $??Right=?54      $??40??55      $??	15,5,15,5q?56      $??10q?57      $??Center=?58      $??14(?5;      $	??300??5<      ??59      ?? $ Post.Keyword?5<      ?? 5=      $??2??6   $	??100??5>      $??Search??5?      $??40??5@      
????  ?$??Right=?5B      ??5C      ?? $ SearchCommand???5D      ?? $ Post.Keyword??? 5F      $??1??6!   $??0??5G   !   $??4??5H   !   $??Right=?5I   !    ?? Orientation$ 
Horizontal=?5J   !   .+?5K      ?? -   5        	 ??Name$	 	uploadBtn??5K   !   $??40??5L      $	??100??5M      $??0,0,10,0q?5N      $??Upload??5O      
????  ?$??Right=?5Q      69   ?? 5S      $??40??5T      $	??100??5U      $??0,0,10,0q?5V      $??Download??5W      
????  ?$??Right=?5Y      ??5Z      ?? $ DownloadCommand?5\      5]      ?? 5^      $??Hidden=?6   .??5_      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 dataGridPost??5d      $	??550??5`      $??Visible=?5a      $	??Top=?5b      $??0,20,0,0q?67   $??15(?5c         AutoGenerateColumns$ False??5e         CanUserAddRows$ False??5f      ??5_      ?? *
Post.Posts+   Columns 5g      0  *System.Windows.Controls.DataGridTextColumn  5h      ,  &System.Windows.Controls.DataGridColumn   Header$ Id??61      
Visibility$ Hidden=?6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   ?? $ Id?6Y     5i      $ Title??61      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6_      
IsReadOnly$
 True??6k    6@   ?? $ Title?6k     5j      $ Description??61   $	 300 6k   $
 True??6w    6F   ?? $ Description?6w     5k      $ Status??61   $	 150 6A   $
 True??6m    6M   ?? $ Status?6m     5l      $ 
Created At??61   $	 150 6E   $
 True??6t    6Q   ?? $ 	CreatedAt?6t     5m      $ 
Created By??61   $	 150 6E   $
 True??6t    6Q   ?? $ 	CreatedBy?6t   4  .System.Windows.Controls.DataGridTemplateColumn  5n      $	 200 65   $
 True??6A      CellTemplate 5o   "   ?? 5p   &   .R?5q   *   ?? $ 
Horizontal=?65   .+?5r   .   ?? $	 editBtn??65   -   5        $
??Edit??5s   1      MaterialDesignOutlinedButton#??[ 5t   1   6g   ?? 5u   .   $??Delete??5v   1   $??10,0,0,0q?5w   1   #??[ 5x   1   ??5y   1   ?? $ DataContext.DeleteCommand? ?? ElementName$ dataGridPost????5z   1   ?? $ Id?5{   +   5|   '   5~      5?      5?      5?      5?      5?      5?      