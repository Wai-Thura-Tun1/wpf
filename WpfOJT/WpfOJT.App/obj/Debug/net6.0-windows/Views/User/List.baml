   M S B A M L   `   `   `  ????E  AWpfOJT.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfOJT.App.Views.UserWpfOJT.App.Views.User  5           WpfOJT.App.Views.User.List   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfOJT.App.Views.User     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N? Title$
  List??5	      $??13(?5
         MaterialDesignBody#???   5      $??Regular"?5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5         TextRenderingMode$
 Auto=?5        MaterialDesignPaper N? 
Background# ?  5        MaterialDesignFont N? 
FontFamily# ?  5      .??5      ? .+?5   
   #  MaterialDesignThemes.Wpf.Card  $	??750??5      $??8q?5      .??5      ?? .+?5      ?  ? RowDefinitions 5      ?? 5      $??* ?6(    ? ColumnDefinitions 5      ?? 5      $	??160 ?6+   ?? 5      $??* ?6+   ?? 5      $	??120 ?6+   ?? 5      $	??180 ?6+   .+?5       ?? $??	User List??5!      $??25(?5"      $
??Bold"?5#      $??0??5$      $??0??5%      $??12,16,12,16q?5&      ?? 5'      $??0??6   $??3??5(      $??40??5)      $	??150??5*      
????  ?$??0,0,10,0q?5,      $??Create New User??5-      $??Right=?5.      ??5/      ??  ?? Path$ CreateCommand??? 50      $??1??6    ! MaterialDesignOutlinedTextBox#??[ 51   "   $??Right=?52   "   $??40??54      $??	15,5,15,5q?55      $??10q?56      $??Center=?57   "   $??14(?58      $	??300??59   "   ??53      ?? $ User.Keyword?59   "   ?? 5:      $??2??6   $	??100??5;      
????  ?$??Search??5=      $??40??5>      $??Right=?5A      ??5?      ?? $ SearchCommand???5@      ?? $ User.Keyword?5A      5C      ?? 5D      $??Hidden=?6   .??5E      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridUser??5J      $??0,20,0,0q?5F      $??15(?5G      $	??600??5H      $??Visible=?5I      	   AutoGenerateColumns$	 False??5K      
   CanUserAddRows$
 False??5L      ??5E      ?? *
User.Users+   Columns 5M      0  *System.Windows.Controls.DataGridTextColumn  5N      ,  &System.Windows.Controls.DataGridColumn   Header$ Id??61      
Visibility$ Hidden=?6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   ?? $ Id?6Y     5O      $
 Name??61      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6a      
IsReadOnly$
 True??6m    6?   ?? $ FullName?6m     5P      $ Email??61   $	 200 6_   $
 True??6k    6@   ?? $ Email?6k     5Q      $
 Role??61   $	 150 6^   $
 True??6j    6?   ?? $ SRole?6j     5R      $ Phone??61   $	 150 6_   $
 True??6k    6@   ?? $ Phone?6k     5S      $ Address??61   $	 300 6c   $
 True??6o    6B   ?? $ Address?6o     5T      $	 DOB??61   $	 150 6\   $
 True??6h    6>   ?? $
 SDob?6h     5U      $ Status??61   $	 150 6a   $
 True??6m    6A   ?? $ Status?6m   4  .System.Windows.Controls.DataGridTemplateColumn  5V      $	 200 65   $
 True??6A      CellTemplate 5W   "   ?? 5X   &   .R?5Y   *   ??  ?? Orientation$ 
Horizontal=?65   .+?5Z   .   ??  ??Name$ editBtn??65   -   5        $
??Edit??5[   1      MaterialDesignOutlinedButton#??[ 5\   1   6g   ?? 5]   .   $??Delete??5^   1   $??10,0,0,0q?5_   1   #??[ 5`   1   ??5a   -   ?? $ DataContext.DeleteCommand? ?? ElementName$ dataGridUser????5b   -   ?? $ Id?5d   +   5e   '   5g      5i      5j      5k      5l      5m      5n      