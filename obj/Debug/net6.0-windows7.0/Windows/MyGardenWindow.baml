   M S B A M L   `   `   `  ����L  HGreenThumbProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GreenThumbProject.WindowsGreenThumbProject.Windows  5   	   .    (GreenThumbProject.Windows.MyGardenWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:GreenThumbProject.Windows     5   	   -   5          � Title$  MyGardenWindow��5   	   $	��550��67   $	��800��6D    � WindowStartupLocation$ CenterScreen=�6Q    � WindowStyle$
 None=�6w    � AllowsTransparency$
 True��6�   
������  � 	Resources 5	         
HeaderText �� 
TargetType �� Property �� Value  ParagraphText  Buttons �� 
TargetType	 �� CornerRadius
 �� Padding �� Triggers P� Property P� Value��%L  &	        &	 �     &	 �    �� 5
   
   " ��6#   .�5      ��  � ��$ 34(�6)   �� 5       � ��$
 Bold"�6+   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � �� �#e7e3fc6+   5      �� 5   
   " ��6&   .�5      ��  � ��$ 23(�6)   �� 5       �@��
LineHeight$ 28��6+   �� 5       � ��$
 Wrap=�6-   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � �� �#e7e3fc6+   5      �� 5   
   " ��6    .�5      ��  � ��$ 16(�6)   �� 5       � ��$	 160��6&   �� 5       �@�FocusVisualStyle 61   Z� �� 5       � ��$	 0 8q�6'   �� 5       � ��
 �����6+   �� 5       � �� �#0D4E3B6+   �� 5       � �� 5      �� 5       " ��6&   .R�5!      �� $	 6��6!   $��1q�62   #��z��6F   
������ $
 15q�6�   ._�5"      �� $��Center=�6/   $��Center=�6L   5#      5$      5&       5'      P� 5(       �@J�IsMouseOver$
 True��61   . �5)      ��  � ��
 ��� �63   5*      5,      5-      .��5.      �� $	 35��6   $��24q�6   ��5/   
   �� 50       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��51      �  � Color$ #53BA77��6    � Offset$	 0.8Q�6/   � 52      $ #1F5A34��6   $	 0.2Q�6/   53      ._�55   
   � -   5         �Name$ 	LogInGrid��55      ��56      �� 57      $	 0,0&�6&   $	 1,1&�67   .��58      � $ #515653��6#   $
 0.86Q�63   � 59      $ #03431A��6#   $
 0.34Q�63   � 5:      $ #1F5A34��6#   $
 0.34Q�63   5;       � ColumnDefinitions 5=      �� 5>      �� 5?      �� 5@      �� 5A      �� 5B      �� 5C       � RowDefinitions 5E      �� 5F      �� 5G      �� 5H      �� 5I      �� 5J      .+�5L      �� -   5        $��3��5L      $��3��6%   $��2��62   $��49��6C   $��80��6O   $��Go��6[   #��[ 6h   $��Center=�6�   $��0,0,0,15q�6�   $��Center=�6�   �� 5M      -   5        $��lblgardenName��5M      $$��Welcome to your digital garden��6)   $��1��6R   $��0��6_   $��5��6o   $��20(�6�   ���	#FFF6EFEF$
��Left=�6�   $	��Top=�6�   $��5,0,0,0q�6�   $��Italic$�6�   �� 5N      -   5         ��Name$ lblgardenAndUser��5N      $��Hello, username��6.   $��5q�6H   $��0��6S   $��4��6`   $��36(�6t   $��Center=�6�   $��Center=�6�   $
��Left=�6�   ���	#FFF9F5F5$��Center=�6�   �� 5O      -   5         ��Name$ 	lstplants��5O      $	��230��6*   $	��240��66   $��2��6C   $��5q�6P   $��3��6[   $��2��6l   $��0��6�   �� 5P      $ ��Add plants to your garden:��6   $��2��69   $��1��6I   $��2��6Z   $��2��6n   $	��Top=�6{   $��18(�6�   $��Center=�6�   ���	#FFFFFBFB$
��Bold"�6�   $��Right=�6�   �� 5Q      $��Remove plant:��6   $	��150��6,   $��1��68   $��2��6H   $��3��6\   $	��Top=�6i   $��16(�6�   $��Center=�6�   ���	#FFFFFBFB$
��Bold"�6�   $��Right=�6�   $��Center=�6�   $��0,10,0,0q�6  �� 5R      $��Plant details:��6   $	��150��6-   $��1��69   $��2��6I   $��3��6]   $��Bottom=�6j   $��16(�6�   $��Center=�6�   ���	#FFFFFBFB$
��Bold"�6�   $��Right=�6�   $��Center=�6�   $��0,5,0,0q�6  �� 5S      -   5         ��Name$ 	btnDelete��5S      #��[ 6(   $��50��6I   $��90��6U   $��3��6`   $��2��6u   $��3��6�   $��Remove��6�   $	��Top=�6�   $��Center=�6�   6�   �� 5T      -   5         ��Name$ cbAddPlantsToGarden��5T      $��2��64   $��1��6D   $��9q�6U   $��2��6`   $��2��6m   $	��200��6�   $��35��6�   $��Right=�6�   ���	#FF4E0909$��Bottom=�6�   �� 5U      -	   5        $ btnaddplant��5U      #��[ 6*   $	��Add��6K   $��4��6s   $��2��6�   $��49��6�   $	��100��6�   $��Bottom=�6�   $��0,0,0,0q�6�   $��Center=�6�   �� 5V      -
   5        $ 	btnReturn��5V      $��5q�6(   #��[ 63   $��50��6T   $��80��6`   $��5��6k   $��4��6{   $��Return��6�   $��16(�6�   $��Bottom=�6�   $��Right=�6�   �� 5W      $&�� Looking for plant care guidance?��6   $��3��6?   $��0��6O   $��2��6\   $��Center=�6p   ���	#FFF4EDED$��16(�6�   $	��Top=�6�   $��Right=�6�   $��Right=�6�   �� 5X      -   5        $ btnInstructiondatabase��5X      ���	#FFD7D7B4$��
Plant care��6L   $��5��6a   $��2��6q   $��40��6�   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   $��Center=�6�   ���	#FFB375756�   5Y      5Z      5[      