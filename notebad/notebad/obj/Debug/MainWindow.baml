   M S B A M L   `   `   `  ����B  >notebad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:notebadnotebad  5   	       notebad.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:notebad     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5   
   $��20 �6   �� 5   
   $
��auto �6   �� 5   
   $��* �6   �� 5   
   $
��auto �6   �� 5   
   $
��auto �6   �� 5   
   $��20 �6    � RowDefinitions 5      �� 5   
   $��20 �6   �� 5   
   $
��auto �6   �� 5   
   $��* �6   �� 5   
   $
��auto �6   �� 5   
   $��20 �6   .+�5      o�  o� 
IsMainMenu . $��8��6   .@�5   
   m� $��files��6   .@�5      m� -   5        $	��New��5      6$   m� 5      -   5        $
��Save��5      6%   m� 5      -   5        $��Save as��5      6(   m� 5      -   5        $
��Load��5      6%   �� 5      m� 5       -   5        $
��Exit��5       6%   5!      m� 5"   
   $
��Edit��6   .@�5#      m� -   5        $��Replace��5#      6(   5$      m� 5%   
   $
��help��6   .@�5&      m� $��Aboult��6   5'      m� 5(   
   -   5        $��settings��5(      6%   5)      �� 5,   
   -   5         ��Name$
 text��5,      $��2��6$   $��2��61    �� AcceptsReturn . " �� VerticalScrollBarVisibility$ Visible=�6o   . �5-   
   /� .T�5.      J� -	   5         �Name$ myParagraph��5.      .*�6+   50      51      52      54      55      