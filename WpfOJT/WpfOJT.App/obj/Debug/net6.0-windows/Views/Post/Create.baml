   M S B A M L   `   `   `  ????E  AWpfOJT.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfOJT.App.Views.PostWpfOJT.App.Views.Post  5      7 clr-namespace:WpfOJT.App.HelpersWpfOJT.App.Helpers  5      "    WpfOJT.App.Views.Post.Create   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfOJT.App.Views.Post     5      3helper clr-namespace:WpfOJT.App.Helpers     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N? Title$  Create??5
      $??13(?5         MaterialDesignBody#???   5      $??Regular"?5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5         TextRenderingMode$
 Auto=?5        MaterialDesignPaper N? 
Background# ?  5        MaterialDesignFont N? 
FontFamily# ?  5      .??5      ? .+?5   
   #  MaterialDesignThemes.Wpf.Card  $	??750??5      $??8q?5      .??5      ?? .+?5      ?? $??Create Post??6   $
??Bold"?5      $??25(?5       ?? Padding$ 15q?5      ? 5      $??0,20,0,0q?6    ? RowDefinitions 5      ?? 5      $	??120 ?6(   ?? 5      $??20 ?6(   ?? 5      $??80 ?6(    ? ColumnDefinitions 5"      ?? 5#      $	??150 ?6+   ?? 5$      $	??250 ?6+   ?? 5%      $	??150 ?6+   ?? 5&      $	??250 ?6+   .+?5)      ?? $??Title??6    $??0??5*      $??0??5+      $	??Top=?5,      $??20,0,0,0q?5-      $??14(?5.      ?? 50       ! MaterialDesignOutlinedTextBox#??[ 6   $??0??51      $??1??52      " ?? VerticalScrollBarVisibility$
 Auto=?53      $??40??54      $??	10,5,10,5q?55      $??Center=?56      $	??220??57      $	??Top=?58      ??59      ?? 	 ?? Path$	 
Post.Title?
 ?? Mode$
 TwoWay=??? 5;      $??Description??6    $??0??5<      $??2??5=      $	??Top=?5>      $??20,0,0,0q?5?      $??14(?5@      ?? 5A      #??[ 6   $??0??5B      $??3??5C      $	??100??5D      $??15,10,15,10q?5E       ?? TextWrapping$
 Wrap=?5F      $??5??5G      $??
15,0,20,15q?5H      $
 Auto=?5I      $	??Top=?5J      ??5K      ?? $	 Post.Description?$
 TwoWay=??? 5M      $??Publish???6   $??1??5N      $??0??5O      $??14(?5P      $??20,0,0,0q?5Q       d? 	IsChecked 5R      ?? $	 Post.IsPublished?$
 TwoWay=??? 5T      $??2??6!   $??0??5U      $??4??5V       ?? Orientation$ 
Horizontal=?5W      $??Center=?5X      .+?5Y      ?? $	??100??6!   $
??Save??5Z      
????  ???5[      ?? $	 SaveCommand?5\      ?? 5^      $	??100??6!   $??Cancel??5_      $??15,0,0,0q?5a      
????  ???5`      ?? $	 CancelCommand?5b      5c      5d      5e      5g      5h      5i      