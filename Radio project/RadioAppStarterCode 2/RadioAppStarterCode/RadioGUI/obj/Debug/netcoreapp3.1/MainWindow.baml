   M S B A M L   `   `   `  ����C  ?RadioGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:RadioGUIRadioGUI  5   	       RadioGUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:RadioGUI     5   	     � Title$  Radio��5   	   $	��150��6   $	��800��6$   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��25 �6   �� 5      $��25 �6   �� 5      .+�5   
   �� -   5         ��Name$ BPlay��5      $
��Play��6    $��3��6/   $��3��6@   6M   �� 5   
   -   5        $ BPause��5      $��Pause��6!   $��4��61   $��3��6B   6O   �� 5    
   -   5        $ BTurnOn��5       $��On��6"   $��2��6/   $��3��6@   6M   �� 5!   
   -   5        $ BTurnOff��5!      $	��Off��6#   $��1��61   $��3��6B   6O   �� 5"   
   -   5        $ 	BVolumeUp��5"      $��	Volume Up��6$   $��5��68   $��2��6I   6V   �� 5#   
   -   5        $ BVolumeDown��5#      $��Volume Down��6&   $��5��6<   $��3��6M   6[   �� 5%   
   -   5         ��Name$ 
DisplayBox��5%      $��5��6&   $��1��6:   $��1��6J    �� TextAlignment$ Center=�6W   $��Center=�6n    �� 
IsReadOnly$
 True��6�   ���	#FFF7F6F66�   �� 5(   
   -   5        $
 BOne��5(      $��1��6   $��1��6+   $��2��6;   6H   �� 5)   
   -	   5        $
 BTwo��5)      $��2��6   $��2��6+   $��2��6;   6H   �� 5*   
   -
   5        $ BThree��5*      $��3��6!   $��3��6-   $��2��6>   6K   �� 5+   
   -   5        $ BFour��5+      $��4��6    $��4��6,   $��2��6=   6K   �� 5.   
   -   5        $ PlaylistOne��5.   $   $��PlayList��6   $��6��69   $��1��6J   6W   �� 5/   
   -   5        $ PreviousSong��5/      $��Previous��6'   $��6��6:   $��3��6K   6X   �� 50   
   -   5        $ NextSong��50      $
��Next��6#   $��6��62   $��2��6B   6O   55      56      