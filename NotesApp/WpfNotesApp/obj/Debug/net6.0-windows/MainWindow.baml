   M S B A M L   `   `   `  ����F  BWpfNotesApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfNotesAppWpfNotesApp  5   	       WpfNotesApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfNotesApp     5   	     � Title$  
Notes List��5   	   $	��450��6   $	��800��6)   .��5	      �� $��0,0,0,2q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$	 DGN��5
      $
��Left=�6       ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6;      
IsReadOnly$
 True��6K      AutoGenerateColumns$ false��5      $��0,5,0,5q�6/      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Priority��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
Priority+  5      $
 Name��6%    63   �� *Name+  5      $ Description��6%    6:   �� *Value+5      � 5   
   $��32��6   .+�5      �� -   5        $��CreateNoteBtn��5   ;   $��Create��6   $��10,5,727,-5q�6&   6P   �� 5      -   5        $��EditNoteBtn��5   9   $
��Edit��6   $��78,5,659,-5q�6$   6L   �� 5      -   5        $��DeleteNoteBtn��5   <   $��Delete��6   $��146,5,591,-5q�6&   6Q   5      5      5      