   M S B A M L   `   `   `  ����A  =KeepMe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KeepMeKeepMe  5   	   ?$clr-namespace:KeepMe.ValueConvertersKeepMe.ValueConverters  5   	       KeepMe.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   &localclr-namespace:KeepMe     5   	   ;
converters$clr-namespace:KeepMe.ValueConverters     5   	   -   5          �Name$  	AppWindow��5   	    � Title$ Keep Me��5   	   $	��525��6   $	��350��6&    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � 	Resources 5         KeepMe.MainWindow �� 
TargetType �� Property �� Value	 �� 
TargetType
 J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Opacity ��Name �� CornerRadius J� OpacityMask !� Visual �� ElementName   
buttonText �� Triggers P� Property P� Value  buttonToolbar��%�  '        &	  �    &	 �    �� 5   
   "  6   .�5      ��  � �� 5      �� 5      "	 �6&   .R�5      �� 
 5        5   "   $ 0Q�63   $	 0.4Q�6C   ._�5      � .+�5   "   �� $ 	Container��6)   $ 4��5   )   
�������5   )   � 5   "    5   &   !� 5   *    66   �� $ 	Container��.+�5   &   �� #��z��67   5    #   5!      5"      5#      5%      5&      �� 5(   
   " ��6#   .�5)      ��  � �� 5*      �� 5+      "	 ��6&   .R�5,      �� #��z��6!   ._�5-      �� $��Center=�6/   $��Center=�6L   5.      5/      51       52      P� 53       �@J�IsMouseOver . . �54      ��  � ��
 ���� 63   55      57      �� 59   
   " ��6&   .�5:      ��  � �� 5;      �� 5<      "	 ��6&   .R�5=      �� $ 20��6!   $��12��5>   1   $��12��5?   1   #��z��5@   1   ._�5A      �� #��z��6/   5B      5C      5E      5F      5G      .��5I      �  � RowDefinitions 5J   
   �� 5K      $
��Auto �6   �� 5L      $��* �6   .+�5P   
   ��  �� Padding$ 
10 10 10 4q�6   ._�5Q      ��  �� Orientation$ 
Horizontal=�6   $��0��5R      .+�5T      �� 
���W�.�$��0 0 5 0q�5U      #��[ 6*   ��5V      �� *MinimizeCommand+�� 5X      
���<��$��0 0 5 0q�5Y      #��[ 6*   ��5Z      �� *CloseCommand+5\      5]      � 5`   
   $��1��6   .+�5a       � -   5          �Name$ 	MainFrame��5a        � NavigationUIVisibility$ Hidden=�6'   ��6G   �� *CurrentPage+:  4KeepMe.ValueConverters.ApplicationPageValueConverter   Instance �� 	Converter# Z �� 5b      -   5        $ SnackBar��5b      $ 10q�5c        PrimaryForegroundBrush#��[ 6"   $��Bottom=�5d      $��
10,0,10,10q�5e      $ 4��6)   y�5f      �� *	Message+@  :KeepMe.ValueConverters.TextCountToVisibilityValueConverter   Instance# Z ._�5g      �  � ColumnDefinitions 5h      �� 5i      $��* �6+   �� 5j      $
��Auto �6+   .+�5m      �� $��0��6    $��12(�5o        �� Padding$ 0 0 10 0q�5p         	GrayBrush#��[ 5q       $��WrapWithOverflow=�5r       ��5n       �� *	Message+ �� FallbackValue$ Successfully added todo.��5r       �� 5t      $��1��6   $��DISMISS��5u      
������ $��0q�5w      
������#��[  5y        � Cursor$
  Hand��5z      ��5{      �� *DismissSnackBarCommand+5}      5~      5      5�      5�      