   M S B A M L   `   `   `  ����B  >MethApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MethAppMethApp  5   	       MethApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MethApp     5   	     � Title$  MethApp��5   	   
������� � WindowState$ 	Maximized=�6+   $	��950��6C   $	��500��6R   $	��615��6b   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��5* �6   �� 5      $��6 �6   �� 5      $
��7.5* �6   .+�5   
   �� $��1��6   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $
 Gray��6#   $
 0.75Q�60   5      5      �� 5   
   $��0��6   $	��Top=�6!   $��5q�69    �� CornerRadius$ 15��6D   $��2q�6V   ��5      �� 5      $	 0,0&�6&   $	 0,1&�67   .��5      � $ White��6#   $ 0Q�61   � 5       $
 Gray��6#   $ 1Q�60   5!      ��5#      �� 5$      $	 0,0&�6&   $	 1,1&�67   .��5%      � $
 Gray��6#   $ 0Q�60   � 5&      $ Black��6#   $
 0.75Q�61   � 5'      $ Black��6#   $ 1Q�61   5(      ._�5,      ��  �� Orientation$ Vertical=�6   $��5q�60   $��Center=�6<   .+�5-      �� -   5        	 ��Name$	 bt_fmr��5-      $��10q�6)   $��5q�6A   $��15(�6M   $
��Bold"�6[   $��FUMIERS��6m   
 � ToolTip$ 
 Ouvrir le menu des fumiers��6�   �� 5.      -   5        $	 bt_chf��5.      $��10q�6)   $��5q�6A   $��15(�6M   $
��Bold"�6[   $��	CHAUFEURS��6m   $#
 Ouvrir le menu des chauffeurs��6�   �� 5/      -   5        $	 bt_exp��5/      $��10q�6)   $��5q�6A   $��15(�6M   $
��Bold"�6[   $��EXPLOITATIONS��6m   $&
  Ouvrir le menu des exploitations��6�   �� 50      -   5        $	 bt_opt��50      $��55,35q�6)   $��0q�6A   $��12(�6M   $��Paramètres��6m   $
 Ouvrir les paramètres��6�   �� 51      -   5        $	 bt_mbu��51      $��10,220,10,10q�6)   $��0q�6A   $��12(�6M   $��Faire une sauvegarde��6m   $N
 HFaire une sauvegarde des données réunies dans un seul fichier .mbackup��6�   �� 52      -   5        $	 bt_lbu��52      $��10q�6)   $��0q�6A   $��12(�6M   $��Chager une sauvegarde��6m   $A
 ;Récupérer les données sécurisées d'un fichier .mbackup��6�   54      55      ]� 58   
   $��2��6   $��Stretch=�6$   $��Stretch=�6B   ��. .+�5:      �� -   5        $	 bt_delbl��5:      $
��10,5q�6>   $��5q�6L   $��15(�6X   $��DemiBold"�6f   $��Bottom=�6|   $y�Hidden=�6�   .��5;      �� 64Supprimer le(s) bon(s) de livraison sélectionné(s)6P   5<      �� 5>      -   5        $	 bt_modbl��5>      $
��10,5q�6>   $��5q�6L   $��15(�6X   $��DemiBold"�6f   $��Bottom=�6|   .��5?      �� ,*Modifier le bon de livraison sélectionné6F   5@      �� 5B      -	   5        $	 bt_addbl��5B      $
��10,5q�6>   $��5q�6L   $��15(�6X   $��DemiBold"�6f   $��Bottom=�6|   .��5C      �� $"Créer un nouveau bon de livraison6?   5D      &   System.Windows.Controls.DataGrid  5F      -
   5          Name$ dg_bls��5F      
����� �$��10q�6U      HeadersVisibility$ Column=�6a   $��3q�6|      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      	RowHeight$ 30Q�6�      RowDetailsVisibilityMode$ Visible=�6�   ��6'   �� *bls+6�   5G      5I      5J      