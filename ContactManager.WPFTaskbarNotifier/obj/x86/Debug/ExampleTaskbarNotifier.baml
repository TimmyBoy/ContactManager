   M S B A M L   `   `   `  ����T  PWPFTaskbarNotifier, Version=1.0.4386.21278, Culture=neutral, PublicKeyToken=nullS<clr-namespace:WPFTaskbarNotifier;assembly=WPFTaskbarNotifierWPFTaskbarNotifier  5      % !ContactManager.WPFTaskbarNotifier6   0WPFTaskbarNotifierExample.ExampleTaskbarNotifier   5      Ctn<clr-namespace:WPFTaskbarNotifier;assembly=WPFTaskbarNotifier  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5        (   "WPFTaskbarNotifier.TaskbarNotifier   Name$  ThisControl��5       � Title$" WPF Taskbar Notifier Example��5      $	��160��6*   $	��300��68    � 	Resources 5	         ItemsTemplate � RowDefinitions � ColumnDefinitions��%�   &	        �� 5      .R�5      �  5   
   �� 5      $
��Auto �6    5   
   �� 5      $	��100 �6   �� 5      $��* �6   5      5      5      .��5      �� $��1q�6   ���	#fff1efe2._�5      �� $��1q�6   ���	#ffffffff._�5      �� $��1q�6   ���	#ffd4d0c8._�5      �  5      �� 5      $��* �6)   .+�5&      #   WPFTaskbarNotifier.NotifyIcon  -   5          Name$ 
NotifyIcon��5&   $      Text$ Example Notifier��68      Icon$ Resources/UFO.ico��6P   . 6�    � ContextMenu 5'      �� 5(      .@�5)   "   m� -   5        $
��Open��5)   +   69   �� 5+   "   m� 5,   "   -   5        $
��Exit��5,   +   69   5-      . 5.   5   5/      � 50      $��5,5,5,5q�6    51      �� 53      $��40 �6   �� 54      $��5 �6   �� 55      $��* �6   �� 56      $��5 �6    58      �� 59      $
��Auto �6   �� 5:      $
��Auto �6   �� 5;      .+�5>      �� -   5        	 ��Name$	 	TitleText��5>      $��0��6/   $��3��6<   $��8,0,8,0q�6P   $��25(�6a   $
��Bold"�6o   $��ContactManager��6�   ��5?      �� 5@      
 �� EndPoint$
 0.5,1&�6$    �� 
StartPoint$ 0.5,0&�65   .��5A      �  � Color$
 Blue��6    � Offset$ 0Q�6,   � 5B      $	 Red��6   $ 1Q�6+   5C      5E      �� 5G      -   5        $��0��5G      $��2��6    $��Right=�60   $	��Top=�6L   $��15��6d   $��15��6o    � ToolTip$
 Hide��5H   2   .��5I      �� ��5J      H� 5K       H� Drawing 5L      � 5M      
 � Pen 5N      >� 5O       >� Brush
 �   � >� 	Thickness$ 3Q�6,    � Geometry 5Q      � 5R      .��5S      ��  �� 
StartPoint$	 0,0&�6)    �� EndPoint$ 20,20&�6:   �� 5T      $
 20,0&�6)   $
 0,20&�6;   5U      5W      5Y      5[      5\      F� 5^      $��3��6   $��3��6    �� Stretch$
 Fill=�62   $��0,0,0,0q�6A   $	��Top=�6R   $��1��6j   ����     ��� X=$ ��	��5_      �� 5`      $
 1,0.5&�6$   $ 0,0.5&�65    � MappingMode$ RelativeToBoundingBox=�6H    � SpreadMethod$ Repeat=�6l   .��5a      � $ White��6   $ 0Q�6-   � 5b      $
 Blue��6   $	 0.1Q�6,   � 5c      $	 Red��6   $	 0.9Q�6+   � 5d      $ White��6   $ 1Q�6-   5e      5g      F� 5u      $��1��6   $��3��6   $
 Fill=�62   $��0,0,0,0q�6A   $	��Top=�6R   $��1��6j   ����     ��� X=$ ��	��5v      �� 5w      $
 1,0.5&�6$   $ 0,0.5&�65   $ RelativeToBoundingBox=�6H   $ Repeat=�6l   .��5x      � $ White��6   $ 0Q�6-   � 5y      $
 Blue��6   $	 0.1Q�6,   � 5z      $	 Red��6   $	 0.9Q�6+   � 5{      $ White��6   $ 1Q�6-   5|      5~      �� 5�      $��0��6   $��2��6!   $��0,5,0,0q�6.   $	��Top=�6?    �� Orientation$ 
Horizontal=�6W   .+�5�      �� ��6   �� *NotifyContent[0].Title+ �� ElementName$ ThisControl���� 5�      $��: ��6   5�      �� 5�   
   $��2��6   $��2��6    $��0,-1,0,0q�6-   $
��Left=�6?   $ Click to open��6Z   .��5�      �� -   5        
 � Tag 5�   )   �� *NotifyContent[0]+$ ThisControl��.�6c   .�5�      �� $
��Wrap=�6[   ��6   �� *NotifyContent[0].Message+$ ThisControl��6[   5�      5�      �� 5�      $��1��6   $��2��6!   $��0,0,0,0q�6.   $
��Left=�6?   $ Click to open��6Z   .��5�      �� $
��Wrap=�6\   ��6   �� *NotifyContent[0].Message2+$ ThisControl��6\   5�      5�      5�      5�   	   5�      5�      5�      