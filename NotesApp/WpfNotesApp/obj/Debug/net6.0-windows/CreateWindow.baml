   M S B A M L   `   `   `  ����F  BWpfNotesApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfNotesAppWpfNotesApp  5   	       WpfNotesApp.CreateWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfNotesApp     5   	     � Title$  Create Note��5   	   $	��450��6   $	��800��6*    � 	Resources 5	       �� 
TargetType �� Property �� Value �� Path �� RelativeSource��%�   '��       �� 5
   
   " ��6   .�5      ��  �@�ToolTip 5      �� 5      $) #(Validation.Errors)[0].ErrorContent�6E    6   �� *Self+6E   5      �� 5       � ��$	 4,4q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� -   5        $��NameTextBox��5    7   $��1��6J   $��30��6Z   $��0 0 15 0q�6f   ��5      �� $
 Name�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� ValidatesOnDataErrors$

 True��.��5    x   5!      �� 5#   
   -   5        $��PriorityTextBox��5&      $��1��6)   $��1��69   $��30��6F   $��0 0 15 0q�6S   ��5#      �� $ Priority�$	 PropertyChanged=�$

 True��.��5&   e   5'      �� 5)   
   -   5        $��ValueTextBox��5+   7   $��1��6K   $��2��6[   $��30��6h   $��0 0 15 0q�6t   ��5)      �� $ Value�$	 PropertyChanged=�$

 True��.��5+   �   5,      �� 5-   
   $
��Name��6   $��30��6   �� 5.   
   $��1��6   $��Priority��6   $��30��60   �� 5/   
   $��2��6   $��Description��6   $��30��63   �� 50   
   -   5        $��CreateNoteBtn��50   �   $��Create��6   $��Center=�6"   $��	0,115,0,0q�6?   $��2��6R   $	��Top=�6_   $��51��6w   6�   �� 51   
   -   5        $��BackBtn��51   �   $��Go back��6   $
��Left=�6#   $��
70,115,0,0q�6>   $��2��6R   $	��Top=�6_   $��51��6w   $��2��6�   6�   52      53      