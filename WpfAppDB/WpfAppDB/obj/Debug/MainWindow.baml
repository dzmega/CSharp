   M S B A M L   `   `   `  ����C  ?WpfAppDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfAppDBWpfAppDB  5   	       WpfAppDB.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfAppDB     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5
         WpfAppDB.Verwaltung  5   
   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��67   $��6��6D   $��10q�6U   ��6   �� *Artikelliste+6U   �� 5   
   $��Artikel einfügen��6   $��20(�6,   $��0��6:   $��1��6G   $��Bottom=�6W   �� 5   
   $
��Name��6   $��14(�6    $��1��6.   $��1��6;   $��Bottom=�6K   �� 5    
   $��Preis��6   $��14(�6!   $��3��6/   $��1��6<   $��Bottom=�6L   �� 5!   
   -   5         ��Name$ txtName��5!      $��2��6#   $��1��60   �� 5"   
   -   5        $ txtPreis��5"      $��4��6$   $��1��61   �� 5#   
   -   5         ��Name$ btnAufnehmen��5#      $��5��6'   $��1��64   $��Artikel Aufnehmen��6D   $��30q�6`   6l   5$      5%      