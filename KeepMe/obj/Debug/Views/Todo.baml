   M S B A M L   `   `   `  ����A  =KeepMe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KeepMe.ViewsKeepMe.Views  5      9!clr-namespace:KeepMe.UserControlsKeepMe.UserControls  5      ?$clr-namespace:KeepMe.ValueConvertersKeepMe.ValueConverters  5          KeepMe.Views.Todo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:KeepMe.Views     5      0uc!clr-namespace:KeepMe.UserControls     5      ;
converters$clr-namespace:KeepMe.ValueConverters     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	      -   5          N�Name$
  root��5       N� 
Background
 ����� N� Title$
 Todo��5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $	��10* �6   .+�5   
   � $��0��6   .+�5      �� 
�������$��0 10 0 0q�6(    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 0Q�6'      Opacity$	 0.2Q�67   5      �� 5       �� Padding$
 16 0q�6   
�������._�5      �  � ColumnDefinitions 5      �� 5       $��* �6+   �� 5!      $
��Auto �6+   .+�5$      �� $��Keep Me��6    $��20(�6/      PrimaryForegroundBrush#��[  6=   $��Center=�6r   �� 5&      $��1��6   $��25��5'      $��25��5(      ��5)      �� *SearchCommand+��5+      �� 5,      	 �� 
TargetType"	 ��6$   .�5-   "   �� 
 �� Property
 � �� �� Value 5.   &   �� 5/   *    �� 
TargetType" ��6:   .R�50   .   �� $#��/Assets/Icons/icon-search.png��64   #��z��51   4   #��z��52   4   53   +   55   #   56      58      5:      5;      �� 5>      $
 16 0q�6   
�������y�67   �� *SearchVisible+<  6KeepMe.ValueConverters.BooleanVisibilityValueConverter   Instance �� 	Converter# Z ._�5?      �  5@      �� 5A      $
��Auto �6+   �� 5B      $��* �6+   .+�5E      �� $��0��6   $��25��5F      $��25��5G      ��5H      �� *SearchCommand+��5J      �� 5K      "	 ��6$   .�5L   "   �� 
 � �� 5M   &   �� 5N   *   " ��6:   .R�5O   .   �� $!��/Assets/Icons/icon-left.png��64   #��z��5P   4   #��z��5Q   4   5R   +   5T   #   5U      5W      �� 5Y      $ 16 10q�6   $��1��6-   ._�5Z      � $��Center=�6    5[      �� 5\   "   $��* �60   �� 5]   "   $
��Auto �60   .+�5`      � $��0��6#   .+�5a   "   �� $��12 4 0 0q�6,     	GrayBrush#��[ 5b   -   $��12(�5c   -   $��
Search ...��5d   -   y�5e   -   ��  �� ElementName$ textBoxSearch�� �� Path$ Text.IsEmpty�@  :KeepMe.ValueConverters.TextInputToVisibilityValueConverter   Instance# Z �� 5g   "   -   5         ��Name$ textBoxSearch��5g   *   
������ $��0q�5h   *   $
��10 4q�5i   *   #��[  5j   *   $��12(�5k   *   .��68   .  (System.Windows.Interactivity.Interaction   Triggers 5l   &   /  )System.Windows.Interactivity.EventTrigger  5m   *      	EventName$ KeyUp��69   .  (System.Windows.Interactivity.TriggerBase   Actions. 5n   .   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6D   �� *SearchQueryCommand+   CommandParameter 5o   D   �� $
 Text�$ textBoxSearch��5p   +   .��5q   >   5r   #   5t      �� 5u      $��1��6(     LightGrayBrush#��[ 65   $��1��6\   5v      5w      5y      5z      5|      �� 5   
   $
��Auto=�6   $��1��6:   .��5�      �� $ 16 20q�6   ._�5�      �  5�      �� 5�      $
��Auto �6(   �� 5�      $��* �6(   .+�5�      �� $��	TODO LIST��6    $��26(�5�      #��[  5�      $��0 0 0 20q�5�      $��0��5�      $��Center=�5�      �� 5�      $
 20 0q�6   $��1��6,   ._�5�      �� ��6'   �� *Todos+��5�      �� 5�   "   .R�5�   &   )   #KeepMe.UserControls.TodoUserControl  	   Id 69   �� *Id+   Description 6K   �� *Description+   	Completed 6o   �� *	Completed+5�   #   5�      5�      �� 5�      $��1��6    $��No data available��6-   $��20(�5�       #��[ 5�       $��Center=�5�       y�5�       �� *Todos+<	  6KeepMe.ValueConverters.CountToVisibilityValueConverter 	  Instance# Z 5�      5�      5�      �� 5�   
   -   5         ��Name$ button��5�        
GreenBrush#��[ 5�      $��40��5�      $��40��6   $��1��6(   $��0q�5�      $��Bottom=�5�      $��Right=�5�      $��16q�5�      ��5�      �� *
AddCommand+��5�      �� 5�      "	 ��6   .�5�      �� 
 � �� 5�      �� 5�      .R�5�   "   � .+�5�   &   �� #��z��6-    �� CornerRadius 6W   �� $ 	Container��$ CornerRadius� 5�   *     5�   .   $ 3Q�6?   $	 0.2Q�6O   5�   '   �� 5�   &    ��Name$ 	Container��6-   #��z��6@    6j   �� *Width+<
  6KeepMe.ValueConverters.WidthCircleRadiusValueConverter 
  Instance  �� 	Converter#  Z ._�5�   *   �� $!��/Assets/Icons/icon-plus.png��60   $��20��5�   0   ��5�   0   �� ! �� RelativeSource! �� *Self+$ Width�5�   '   5�   #   5�      5�      5�      5�      5�      5�      