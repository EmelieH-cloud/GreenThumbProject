   M S B A M L   `   `   `  ����L  HGreenThumbProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GreenThumbProject.WindowsGreenThumbProject.Windows  5   	   2    ,GreenThumbProject.Windows.PlantDetailsWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:GreenThumbProject.Windows     5   	   -   5          � Title$  PlantDetailsWindow��5   	   $	��440��6$    � WindowStartupLocation$ CenterScreen=�6H   $	��600��6m    � WindowStyle$
 None=�6y    � AllowsTransparency$
 True��6�   
������  � 	Resources 5	         plantdetail �� 	UriSource  Buttons �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� CornerRadius �� Padding �� Triggers P� Property P� Value��%�  &	        &	 S     �� 5
   
   $? 9C:\Users\User\repos\Newton\GreenThumbProject\monstera.jpg?�6*   �� 5   
   " ��6    .�5      ��  � ��$	 160��6&   �� 5       �@�FocusVisualStyle 61   Z� �� 5       � ��
 �����6+   �� 5       � �� �	#FF092A096+   �� 5       � �� 5      �� 5      "	 ��6&   .R�5      �� $
 6��6!   $��1q�62   #��z��6F   
������ $ 15q�6�   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � ��
 ��� �63   5      5      5      .��5       �� $
 35��6   $��21q�6   ��5!   
   �� 5"       �� Color$ black��6   ._�5$   
   � -   5         �Name$ detailsgrid��5$      ��5%      �� 5&       �� ImageSource# [  6    j� Stretch$ UniformToFill=�6H    � ColumnDefinitions 5(      �� 5)      �� 5*      �� 5+      �� 5,      �� 5-       � RowDefinitions 5/      �� 50      �� 51      �� 52      �� 53      �� 54      .+�56      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridInstructions��56      $	��130��65   $	��490��6B      AutoGenerateColumns$ False��6N   $��3��6j   $��10q�6w   $��0��6�   $��5��6�   $��2��6�      Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ InstructionId ��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *InstructionId+  59      $ Instruction ��6)    6?   �� *	Content+5;      �� 5<      -   5         ��Name$ txtPlantDetails��5<   E   $��10q�6   $
��Wrap=�6%   $��80��69   $��0��6^   
�������$��2��6�   $��1��6�   $��5��6�   �� 5=      -   5         ��Name$ 	btnReturn��5=      #��[ 6(   $��4��6J   $��0��6Z   $��90��6g   $��60��6r   $��Close��6~   $��Center=�6�   $��Center=�6�   $��14(�6�   �� 5>      -   5         ��Name$ lblplantName��5>      $��Plant details: ��6*   $��0��6D   $��0��6Q   $��5��6a   $��Center=�6u   $��Center=�6�   $��24(�6�   ���	#FFF6EAEA$
��Bold"�6�   5?      5@      5A      