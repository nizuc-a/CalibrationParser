   M S B A M L   `   `   `  ����W  SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ComboBoxLightColor  �� Color  ComboBoxLightTextColor  ComboBoxLightMouseOverColor # ComboBoxLightButtonPressedColor  ComboBoxToggleButton �� 
TargetType � ColumnDefinitions ��Name �� CornerRadius F�Name �� Triggers P� Property P� Value	 �� 
TargetName
 �� Value �� Property  ComboBoxTextBox  ComboboxStyle �� 
TargetType �� 	ClickMode d� 	IsChecked �� Path �� Mode �� RelativeSource J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly �� 
IsReadOnly �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight K� IsItemsHost-   'System.Windows.Input.KeyboardNavigation    DirectionalNavigation P� 
SourceName  �� Triggers! �� Padding�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %r  &	        &	 !     &	 B     &	 c     &	 �     &	 D    &	 �    7  7  '�� �    �� 5      $  #d9d9d9��6.   �� 5      $  #111111��62   �� 5      $  #b3b3b3��67   �� 5      $  #9e9e9e��6;   �� 5	      " d�60   .R�5
      �  5      �� 5      �� 5      $��20 �6   .+�5      �� $ Border��6   $��2��5      $ 5 ��5      #���   5      �� 5      $��0��6   $ 5 0 0 5��5      $��1q�5      #���   5      F� 5      $ Arrow��6
   $��1��5   
   
���   �$��Center=�5   
   $��Center=�5   
   =����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	5   
   5       5      P� 5       �@J�IsMouseOver$
 true��6:   . �5       �� $	 Border��6   #
 �  5!       � ��5"      P� 5#       �@d�	IsChecked$
 trueY�68   . �5$      �� $	 Border��6   #
 �  5%       � ��5&      5(      �� 5)      " ��6+   .R�5*      �� $ PART_ContentHost��6   $|�False��5+      #��z��5,      5-      �� 5.      " ��6   .�5/      ��  �@J�SnapsToDevicePixels$

 true��6*   �� 50       �@�OverridesDefaultStyle$

 true��6,   �� 51       � ��$

 Auto=�6A   �� 52       � ��$

 Auto=�6?   �� 53       � ��$

 true��64   �� 54       � ��$	
 120��6   �� 55       � ��$
 20��6    �� 56       � ��#
 �  6!   �� 57       � ��
 58      �� 59      " ��6   .R�5:      � .+�5;      d� $��ToggleButton��5<      8��  $��2��5>      $|�false��5?      $ Press=�5A       5@      �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+5B   	   �� 5C      $��ContentSite��6   $ False��6,   #��z 6E   #��z 5D      #��z��5E      $��3,3,23,3q�5F      $��Center=�5G      $
��Left=�5H      �� 5I      $ PART_EditableTextBox��6   8�� $
��Left=�5L      $��Center=�5M      $��3,3,23,3q�5N      $
|�True��5O      ���	#FF3F3F3F
��� � �$y�Hidden=�5R      # z 5S      ��5J      Z� 5S      � 5T      $��Popup��5U      $��Bottom=�5V      #��z 5W      $
 True��5X      $|�False��5Y      $��Slide=�5Z      .��5\   	   � $��DropDown��6   $
 True��5]      #��z 5^      #��z 5_      .+�5`   
   �� $ DropDownBorder��6   #���   5a   
   $��1q�5b   
   #���  5c   
   �� 5d   
   $��4,6,4,6q�6   $
 True��6(   .��5e      �� $
 True��6   $ 	Contained=�6)   5f      5g   
   5h   	   5i       5j      P� 5k       �@��HasItems$ false��6$   . �5l   	   �� $	 DropDownBorder��6    � ��$
 95��6A   5m   	   P� 5n       � {�$ false��6%   . �5o   	   ��  � ��
 �#8888886&   5p   	   P� 5q       �@��
IsGrouping$
 true��6&   . �5r   	   ��  � ��$
 false��69   5s   	   P� 5t      $ Popup��6    �@�AllowsTransparency$
 true��6G   . �5u   	   �� $	 DropDownBorder��6    �@��CornerRadius$
 5��6D   �� 5v   	   $	 DropDownBorder��6    � ��$
 0,2,0,0q�6>   5w   	   P� 5x       �@��
IsEditable$
 true��6&   . �5y   	   ��  � ��$
 false��6%   �� 5z   	   $	 PART_EditableTextBox��6    � y�$
 Visible=�6H   �� 5{   	   $	 ContentSite��6    � y�$
 Hidden=�6?   5|   	   5~      5�        5�      5�      �� 5�      " ��6'   .�5�      ��  �@J�SnapsToDevicePixels$

 true��6*   �� 5�       � ��#
 �  6!   �� 5�       �@�OverridesDefaultStyle$

 true��6,   �� 5�       � ��
 5�      �� 5�      " ��6   .R�5�      �� $��Border��6   $! 2q�5�      $
 true��5�      $ 3��5�      ._�5�      �� 5�       5�      P� 5�       �@��IsHighlighted$
 true��6)   . �5�   	   �� $	 Border��6   #
 �  6:    � ��5�   	   P� 5�       � {�$ false��6%   . �5�   	   �� #
 �  6&    � ��5�   	   5�      5�      5�      5�      