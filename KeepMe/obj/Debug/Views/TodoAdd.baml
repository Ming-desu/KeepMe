   M S B A M L   `   `   `  ����A  =KeepMe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KeepMe.ViewsKeepMe.Views  5      ?$clr-namespace:KeepMe.ValueConvertersKeepMe.ValueConverters  5          KeepMe.Views.TodoAdd   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:KeepMe.Views     5      ;
converters$clr-namespace:KeepMe.ValueConverters     5        N� 
Background
  ����� N� Title$ Todo Add��5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $	��10* �6   .+�5   
   � $��0��6   .+�5      �� 
�������$��0 10 0 0q�6(    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 0Q�6'      Opacity$	 0.2Q�67   5      �� 5       �� Padding$
 16 0q�6   
�������._�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $��* �6+   �� 5      $
��Auto �6+   .+�5"      �� $��Add New Todo��6    $��20(�64   $
��16 0q�5#       $��1��5$          PrimaryForegroundBrush#��[  5%       $��Center=�5&       �� 5(      $��0��6   $��25��5)      $��25��5*      ��5+      �� *BackCommand+��5,      �� 5-       �� 
TargetType" ��6$   .�5.   "   �� 	 �� Property	 � ��
 �� Value
 5/   &   �� 50   *    �� 
TargetType" ��6:   .R�51   .   �� $!��/Assets/Icons/icon-left.png��64   #��z��52   4   #��z��53   4   54   +   56   #   57      59      �� 5;      $��2��6   $��25��5<      $��25��5=      ��5>      �� *AddTodoCommand+��5?      �� 5@      " ��6$   .�5A   "   �� 	 � ��
 5B   &   �� 5C   *   " ��6:   .R�5D   .   �� $!��/Assets/Icons/icon-save.png��64   #��z��5E   4   #��z��5F   4   5G   +   5I   #   5J      5L      5N      5O      5P      �� 5S   
   $ 16 20q�6   $��1��6!   ._�5T      � .+�5U      �� $
 20 0q�6   ._�5V      ��  �� Orientation$ Vertical=�6!   .+�5W      �� $��Todo Description��6$   $��12(�5X   $   ��5Y   $   �� *PrimaryForegroundBrush+�� 5[      $��4q�6"   $	��0 4q�6.   ��6;   �� *Todo.Description+ �� Mode$ TwoWay=��� 5]      $	��ADD��6!     PrimaryBrush#��[ 6/   
�������$��4q�5^   4   $��12(�5_   !   $��0q�5`   !   $��Right=�5a   !   $��80��5b   !   ��5c   !   �� *AddTodoCommand+5e      5f      5g      5h      5i      5j      5k      