   M S B A M L   `   `   `  ����L  HGreenThumbProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GreenThumbProject.WindowsGreenThumbProject.Windows  5   	   )    #GreenThumbProject.Windows.AdminView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:GreenThumbProject.Windows     5   	     � Title$  	AdminView��5   	   $	��540��6    � WindowStartupLocation$ CenterScreen=�6(   $	��600��6M    � WindowStyle$
 None=�6Y    � AllowsTransparency$
 True��6m   
������  � 	Resources 5	         
HeaderText �� 
TargetType �� Property �� Value  ParagraphText  Buttons �� 
TargetType	 �� CornerRadius
 �� Padding �� Triggers P� Property P� Value��%  &	        &	 �     &	 �    �� 5
   
   " ��6#   .�5      ��  � ��$ 34(�6)   �� 5       � ��$
 Bold"�6+   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � �� �#e7e3fc6+   5      �� 5   
   " ��6&   .�5      ��  � ��$ 23(�6)   �� 5       �@��
LineHeight$ 28��6+   �� 5       � ��$
 Wrap=�6-   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � �� �#e7e3fc6+   5      �� 5   
   " ��6    .�5      ��  � ��$	 160��6&   �� 5       �@�FocusVisualStyle 61   Z� �� 5       � ��
 �����6+   �� 5       � �� �	#FF092A096+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $	 6��6!   $��1q�62   #��z��6F   
������ $
 15q�6�   ._�5       �� $��Center=�6/   $��Center=�6L   5!      5"      5$       5%      P� 5&       �@J�IsMouseOver$
 True��61   . �5'      ��  � ��
 ��� �63   5(      5*      5+      .��5,      �� $	 35��6   $��24q�6   ��5-   
   �� 5.       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5/      �  � Color$ #215834��6    � Offset$	 0.2Q�6/   � 50      $ #247E44��6   $	 0.6Q�6/   � 51      $ #1F5A34��6   $	 0.9Q�6/   52      ._�54   
   � -   5         �Name$ 	LogInGrid��54      ��55      �� 56      $	 0,0&�6&   $	 1,1&�67   .��57      � $ #215834��6#   $	 0.8Q�63   � 58      $ #247E44��6#   $	 0.5Q�63   � 59      $ #1F5A34��6#   $	 0.1Q�63   � 5:      $ 	LightGray��6#   $	 0.8Q�65   5;       � ColumnDefinitions 5=      �� 5>      �� 5?      �� 5@      �� 5A      �� 5B       � RowDefinitions 5D      �� 5E      �� 5F      �� 5G      �� 5H      �� 5I      .+�5K      �� -   5         ��Name$ btnPlantDatabase��5K      $��1��6/   $��Manage plants��6A   $	��150��6Y   $��2��6e   $��2��6u   $��1��6�   #��[ 6�   $
��Left=�6�   $��Center=�6�   $��16(�6�   6�   �� 5L      -   5        $ btnUserDatabase��5L      $��
View users��6.   $	��150��6C   $��2��6O   $��2��6_   $��1��6t   $��2��6�   #��[ 6�   $
��Left=�6�   $��Center=�6�   $��16(�6�   6�   �� 5M      -   5        $ btninstructiondatabase��5M      $��2��65   $	��150��6I   $��60��6U   #��[ 6a   $��2��6�   $��3��6�   $��Instruction catalog��6�   $��Center=�6�   $
��Left=�6�   $��14(�6  �� 5N      $��10q�6   $��0��6$   
�������$��2��6G   $��2��6T   $I��CExplore and manage plants in our database using the plant feature. ��6h   $
��Wrap=�6�   $
��Left=�6�   $��Center=�6�   $��14(�6�    �� TextAlignment$ Center=�6  �� 5O      $��10q�6   $��0��6$   
�������$��1��6G   $��2��6T   $A��;Easily oversee user accounts with the 'View Users' feature.��6h   $
��Wrap=�6�   $��Center=�6�   $��Center=�6�   $��14(�6�   �� 5P      $��10q�6   $��0��6$   
�������$��3��6G   $��2��6T   $\��VPlantcare instructions. Note that some plants have more than one instruction attached.��6h   $
��Wrap=�6�   $��Center=�6�   $��Center=�6�   $��14(�6  �� 5Q      -   5        $ 	btnReturn��5Q      #��[ 6(   $��4��6I   $��4��6Y   $��80��6f   $��45��6q   $��Return��6}   6�   �� 5R      $��Admin options��6   $��1��6,   $��5��6=   $��Center=�6Q   $��Center=�6n   $��36(�6�   $
��Bold"�6�   ���	#FFF8EAEA$��Center=�6�   $��Center=�6�   5S      5T      5U      