   M S B A M L   `   `   `  ����D  @projet-UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:projet_UI	projet_UI  5   	       projet_UI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:projet_UI     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��400��6+    � 	Resources 5
         cellule � ColumnDefinitions��%w  &	        �� 5   
   .R�5      �  5      �� 5      $��* �6'   �� 5      $��30 �6'   �� 5      $��* �6'   �� 5      $��30 �6'   �� 5      $��* �6'   .+�5      �� $��0��6/   ��6   �� *X+6/   �� 5      $��2��6/   ��6   �� *Y+6/   �� 5      $��4��66   ��6   �� *
Nomville+66   5      5      5      .��5      � .+�5   
   �� .@�5      �� $��Carte��6   .��5      �  5       �� 5!      $
��100* �6+   6:   �� 5"      $	��36* �6+   �� 5#      $
��241* �6+   �� 5$      $
��377* �6+   6:   .+�5&      �� -   5         ��Name$ canva��5&      $
��Left=�6I   $	��264��6d   $��10q�6q   $	��Top=�6}   $	��500��6�   $��3��6�   .+�5'      �� $��ressource/france.jpg��6    $	��508��6>    �� Left$ 1��6K   $	��359��6[   5(      �� 5*      $��3��6   #��[  6/   $��1,0,0,0q�6v   ��6W   �� *Villes+6v   5+      5,      �� 5.      $��Listes��6   .��5/      �  � RowDefinitions 50      �� 51      $
��auto �6(   68   �� 52      $��6* �6(   66   .+�55      &   System.Windows.Controls.DataGrid  -   5        $��grid_seconde��55   f   $��1��6   $��
10,10,10,0q�6,   $
��auto��6@   $	��Top=�6N      
IsReadOnly .    AutoGenerateColumns .  ��6z   �� *Villes+   Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Ville��61   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 250 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *
Nomville+6^     58      $	 X��61   $	
 100 6S    6<   �� *X+6S     59      $	 Y��61   $	
 100 6S    6=   �� *Y+6S   5;      5=      5>      �� 5@      $	��Run��6   5A      �� 5C      $��Parametrage��6   .��5D      � $	��100q�6   .+�5F      �� .+�5H      �� .��6    Taille de la population:6:   �� 5I      $��10q�6"   ��6.   �� *Taille_population+�� 5K      .��6    	Mutation:6+   �� 5L      $��10q�6#   ��6/   �� *
Mutation+�� 5N      .��6    
CrossOver:6,   �� 5O      $��10q�6"   ��6.   �� *	CrossOver+�� 5Q      .��6    Elite:6(   �� 5R      $��10q�6"   ��6.   �� *Elite+6G   5U      5V      5Y      5]      5^      5`      