   M S B A M L   `   `   `  ????B  >Module1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Module1Module1  5          Module1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      'localclr-namespace:Module1     5        ? Title$  Employee Management??5      $	??549??6   $	??915??6+    ? WindowStartupLocation$ CenterScreen=?5	      .??5      ? -   5         ?Name$ grid_container??5      $??10,30,10,-6q?6#   ??5   
   ?? 5       ?? EndPoint$ 0.5,1&?6"    ?? 
StartPoint$ 0.5,0&?63   .??5      ?  ? Color$ Black??6   ? 5      $ 	#FFF9E8E8??6    ? Offset$ 1Q?61   5      .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtGridAccounts??5      $??Center=?5      $	??225??5      $	??Top=?5      $	??894??5         GridLinesVisibility$	 All=?5      $??15(?6-   	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 5      ??5      ?? 5   #   ?? 5   
   $??Name:??6   $
??Left=?5      $??
40,241,0,0q?5      $	??Top=?5      $??23??5       $??60??6   ?? 5"   
   $
??Age:??6   $
??Left=?5#      $??
48,276,0,0q?5$      $	??Top=?5%      $??26??5&      $??45??6   ?? 5(   
   $??Salary:??6   $
??Left=?5)      $??
36,312,0,0q?5*      $	??Top=?5+      $??26??5,      $??58??6   ?? 5.   
   $??Date:??6   $
??Left=?5/      $??
44,347,0,0q?50      $	??Top=?51      $??24??52      $??45??6   ?? 54   
   $??Phone:??6   $
??Left=?55      $??
37,381,0,0q?56      $	??Top=?57      $??24??58      $??62??6   ?? 5:   
   -   5        
 ??Name$
 txtbox_Name??5:      $
??Left=?5;      $??21??5<      $??
99,241,0,0q?6    ?? TextWrapping$
 Wrap=?5=      $	??Top=?5>      $	??239??5?      ?? 5A   
   -   5        $
 
txtbox_Age??5A      $
??Left=?5B      $??24??5C      $??
98,276,0,0q?6   $
 Wrap=?62   $	??Top=?6F   $	??239??6^   ?? 5E   
   -   5        $
 txtbox_Salary??5E      $
??Left=?5F      $??23??5G      $??
98,313,0,0q?6   $
 Wrap=?5H      $	??Top=?6&   $	??239??5I      (  "System.Windows.Controls.DatePicker  5J   
   -   5          Name$ txtbox_Date??5J      $
??Left=?5K      $??
98,347,0,0q?5L      $	??Top=?5M      $??24??5N      $	??239??6!   ?? 5O   
   -   5        $
 txtbox_Phone??5O      $
??Left=?5P      $??24??5Q      $??100,381,0,0q?6   $
 Wrap=?5R      $	??Top=?5S      $	??239??5T      ?? 5U   
   -   5         ??Name$ button_Insert??5U      $??Insert??5V      $
??Left=?5W      $??28??5X      $??102,418,0,0q?6   $	??Top=?5Y      $??68??6)   64   ?? 5Z   
   -	   5        $ button_Delete??5Z      $??Delete??5[      $
??Left=?5\      $??28??5]      $??274,419,0,0q?6   $	??Top=?5^      $??66??6)   64   ?? 5`   
   -
   5        $ button_Clear??5`      $??Clear??5a      $
??Left=?5b      $??28??5c      $??188,419,0,0q?6   $	??Top=?5d      $??68??6)   64   5e      5f      