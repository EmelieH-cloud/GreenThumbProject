   M S B A M L   `   `   `  ����L  HGreenThumbProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GreenThumbProject.WindowsGreenThumbProject.Windows  5   	   +    %GreenThumbProject.Windows.PlantWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:GreenThumbProject.Windows     5   	   -   5          � Title$  PlantWindow��5   	   $	��480��64    � WindowStartupLocation$ CenterScreen=�6A   $	��750��6f    � WindowStyle$
 None=�6r    � AllowsTransparency$
 True��6�   
������  � 	Resources 5	         
HeaderText �� 
TargetType �� Property �� Value  ParagraphText  Buttons �� 
TargetType	 �� CornerRadius
 �� Padding �� Triggers P� Property P� Value��%'  &	        &	 �     &	 �    �� 5
   
   " ��6#   .�5      ��  � ��$ 34(�6)   �� 5       � ��$
 Bold"�6+   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � �� �#e7e3fc6+   5      �� 5   
   " ��6&   .�5      ��  � ��$ 23(�6)   �� 5       �@��
LineHeight$ 28��6+   �� 5       � ��$
 Wrap=�6-   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � �� �#e7e3fc6+   5      �� 5   
   " ��6    .�5      ��  � ��$ 16(�6)   �� 5       � ��$	 160��6&   �� 5       �@�FocusVisualStyle 61   Z� �� 5       � ��
 �����6+   �� 5       � �� �#447D586+   �� 5       � �� 5      �� 5      " ��6&   .R�5       �� $	 6��6!   $��1q�62   #��z��6F   
������ $
 15q�6�   ._�5!      �� $��Center=�6/   $��Center=�6L   5"      5#      5%       5&      P� 5'       �@J�IsMouseOver$
 True��61   . �5(      ��  � ��
 ��� �63   5)      5+      5,      .��5-      �� $	 35��6   $��24q�6   ��5.   
   �� 5/       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��50      �  � Color$ #204F31��6    � Offset$	 0.8Q�6/   � 51      $ #062C12��6   $	 0.2Q�6/   52      ._�54   
   � -   5         �Name$ 	LogInGrid��54      ��55      �� 56      $	 0,0&�6&   $	 1,1&�67   .��57      � $ #204F31��6#   $	 0.8Q�63   � 58      $ #062C12��6#   $	 0.2Q�63   59       � ColumnDefinitions 5;      �� 5<      �� 5=      �� 5>      �� 5?      �� 5@      �� 5A      �� 5B       � RowDefinitions 5D      �� 5E      �� 5F      �� 5G      �� 5H      �� 5I      .+�5K      &   System.Windows.Controls.DataGrid  -   5          Name$ DatagridPlants��5K   Y   $��0��6   $��4��6'   $��1��68   $��4��6E   $	��380��6q      AutoGenerateColumns$ False��6~   $	��280��6�      Columns 5L      0  *System.Windows.Controls.DataGridTextColumn  5M      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6)      Header$ PlantID��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	PlantId+  5N      $ * 6)   $ Product Name��63    6I   �� *	PlantName+5P      �� 5Q      $��Search plant:��6   $��2��6,   $��18(�6@   $
��Bold"�6N   
�������6`   �� 5R      -   5         ��Name$ txtSearchTerm��5R   \   $��Center=�6   $��Center=�68   $��0��6s   $��2��6�   $��40��6�   $��Bottom=�6�   6�   �� 5S      -   5         ��Name$ btnSearchPlant��5S      $��2��6-   $��Go��6=   $��50��6J   $��60��6V   #��[ 6a   $
��Bold"�6�   $��Bottom=�6�   ���	#FF0600006�   �� 5T      -   5        $ btnDeletePlant��5T      $��4��6-   $��2��6=   $��50��6Q   $	��150��6]   $��3��6i   #��[ 6v   $��Delete plant��6�   $��14(�6�   6�   �� 5U      -   5        $ btnDetailsPlant��5U      $��4��6.   $��2��6>   $��50��6R   $	��150��6^   $��4��6j   #��[ 6w   $��Plant details��6�   $��14(�6�   $	��Top=�6�   �� 5V      -   5        $ btnAddPlantsWindow��5V      $��2��61   $��4��6E   $��50��6U   $	��150��6a   $��2��6m   #��[ 6z   $��
Add plants��6�   $��14(�6�   $��Bottom=�6�   �� 5W      -	   5        $ btnClearFilter��5W      $��12(�6.   $��Clear search��6<   $��50��6S   $	��100��6_   #��[ 6k   $��3��6�   $
��Bold"�6�   $��Bottom=�6�   �� 5X      -
   5        $ 	btnReturn��5X      #��[ 6(   $��6��6I   $��50��6Y   $	��100��6e   $��0��6r   $��Return��6   $	��Top=�6�   5Y      5Z      5[      