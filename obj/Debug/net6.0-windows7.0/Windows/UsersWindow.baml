   M S B A M L   `   `   `  ����L  HGreenThumbProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GreenThumbProject.WindowsGreenThumbProject.Windows  5   	   +    %GreenThumbProject.Windows.UsersWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:GreenThumbProject.Windows     5   	   -   5          � Title$  UsersWindow��5   	   $	��500��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�6N    � WindowStyle$
 None=�6t    � AllowsTransparency$
 True��6�   
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
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5/      �  � Color$ #1F5A34��6    � Offset$	 0.3Q�6/   � 50      $ #156F34��6   $	 0.2Q�6/   51      ._�53   
   � -   5         �Name$ 	LogInGrid��53      ��54      �� 55      $	 0,0&�6&   $	 1,1&�67   .��56      � $ #1F5A34��6#   $	 0.8Q�63   � 57      $ #156F34��6#   $	 0.2Q�63   58       � ColumnDefinitions 5:      �� 5;      �� 5<      �� 5=      �� 5>      �� 5?       � RowDefinitions 5A      �� 5B      �� 5C      �� 5D      �� 5E      �� 5F      .+�5H      �� $��Registered users��6   
�������$��5��6B   $��Center=�6V   $��Center=�6z   $��36(�6�   $
��Bold"�6�   �� 5I      -   5         ��Name$ lstUsers��5I      $��1��6*   $��1��67   $	��300��6G   $	��300��6S   $��3��6`   $��4��6t   �� 5J      -   5        $��4��5J      #��[ 6%   $��4��6F   $��80��6S   $��50��6^   $��Return��6j   6{   5K      5L      5M      