   M S B A M L   `   `   `  ����A  =KeepMe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:KeepMe.ValueConvertersKeepMe.ValueConverters  5      )    #KeepMe.UserControls.TodoUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;
converters$clr-namespace:KeepMe.ValueConverters     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      -   5          >�Name$
  root��5      $��50��5	      $	��200��5
      .��5      � .+�5   
   ��    BackgroundLightBrush#��[  6    �� Padding$ 10q�5      $��0 0 0 4q�5       �� CornerRadius$ 4��5      ._�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $��* �6'   .+�5      �� $��Center=�6   $��0��66    d� 	IsChecked 6F   �� *	Completed+ �� ElementName$
 root��7  1KeepMe.ValueConverters.IntToBooleanValueConverter   Instance �� 	Converter# Z  �� Mode$ TwoWay=��� 5      $
 10 0q�6   $��1��6(   ._�5      �� $��14(�5         PrimaryForegroundBrush#��[ 5       $��Center=�5       $��WrapWithOverflow=�5!       ��5       �� *Description+$
 root��	 �� FallbackValue$	 Todo Description����5        �� *	Completed+$
 root��D  >KeepMe.ValueConverters.CompletedToTextDecorationValueConverter
   Instance# Z
 5!       5"      5#      5$      5%      5'      