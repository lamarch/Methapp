   M S B A M L   `   `   `  ����B  >MethApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MethAppMethApp  5   	       MethApp.win_EXP   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MethApp     5   	   -   5          � Title$  Exploitations��5   	   
�������$
��1000��61   $
��1000��6>    � WindowStartupLocation$ CenterScreen=�6L    � 	Resources 5	         bts �� Property �� Value��%�   &	        �� 5
   
   .�5      ��  � ��$ 15(�60   �� 5       � ��$ DemiBold"�62   �� 5       � ��$ 35��6.   �� 5       � ��$
 15,5q�6.   5      5      .��5      ]� $��10q�6   ��. $��Stretch=�61   $��Stretch=�6O   .+�5   
   � $��Bottom=�6    � 	ItemWidth$	 350��6,   $��Center=�6<   .+�5      �� -   5         ��Name$ 	newobj_bt��5      #���   6@   .��6j   Ajouter une exploitation6�   �� 5      -   5        $ 	delobj_bt��5      #���   6@   .��6j   Supprimer une exploitation6�   �� 5      -   5        $ 	savels_bt��5      #���   6@   $y�Hidden=�6j   .��6~   Sauvegarder les exploitations6�   �� 5      -   5        $ 	return_bt��5      #���   6@   $y�Hidden=�6j   .��6~   	Annuler6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��datag��5         
IsReadOnly .  $	��Top=�63   
�������$��10q�5   &   $��17(�62      ColumnHeaderHeight$ 30Q�5      	   	RowHeight$	 30Q�6'   
   MinColumnWidth$	
 200Q�66      GridLinesVisibility$ 
Horizontal=�5         HeadersVisibility$ Column=�5         RowBackground
 �����   AlternatingRowBackground
 �����
���   �$��2q�5    #   "   VerticalScrollBarVisibility$
 Auto=�5!      $   HorizontalScrollBarVisibility$
 Auto=�5"         AutoGenerateColumns .     SelectionMode$ Extended=�5%         CanUserAddRows .  ��5#      �� *Ex+   Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Nom :��6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Nom+6=     5+      $ 	Adresse :��6A    6%   �� *	Adresse+6A     5,      $ Exploitants :��6E    6%   �� *Exploitants+6E      RowDetailsTemplate 5/      �� 50      .R�51      �� 
���������64   �� *
LongDesc+52      54      57      58      