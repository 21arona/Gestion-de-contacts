   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewView  5   	       View.Rechercher   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:View     5   	     � Title$  
Rechercher��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      � $��0,0,-8,0q�6    � ColumnDefinitions 5
   
   �� 5      $
��539* �6   �� 5      $
��298* �6   .+�5   
   �� $,��&Entrer le nom de contact à chercher :��6   $
��Left=�6@   $��10,0,0,0q�6[   $	��Top=�6m   $	��439��6�   $��42��6�   $��24(�6�   $
��Bold"�6�      FontFamily1#���   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$	 dgr��5      $
��Left=�6    $	��363��6;   $��0,42,0,0q�6H   $	��Top=�6Z   $	��800��6r   $��2��6~   �� 5   
   -   5         ��Name$ chercher��5      $��Chercher��6#   $
��Left=�66   $��99,0,0,0q�6Q   $	��Top=�6c   $	��162��6{   $��56��6�   $
��Bold"�6�   $��30(�6�   $��Segoe UI Black)�6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ 	txtSearch��5      $��2��6%   $
��Left=�69   $��32��6T   $��
464,10,0,0q�6`    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��120��6�   4  .System.Windows.Automation.AutomationProperties   Name$ textBoxChercher��6�   5      5      