   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp1.PageWpfApp1.Page  5           WpfApp1.Page.MainAbminPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WpfApp1.Page     5        N� Title$  MainAbminPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��60* �6   �� 5      $
��165* �6   �� 5      $
��172* �6   �� 5      $	��53* �6   .+�5   
   �� $��1��6   $��2��6"   $��Center=�63   $��Center=�5      .+�5      &   System.Windows.Controls.DataGrid  -   5        $��
MyDataGrid��5         AutoGenerateColumns .  $��10q�6E   $	��300��5         
IsReadOnly .    Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6-      CellTemplate 5      �� 5      .R�5   "   �  5   &   �� 5   *   �� 5   *    � ColumnDefinitions 5   &   �� 5    *   �� 5!   *   .+�5#   &   ��  �� Orientation$ 
Horizontal=�61   $��0��6J   $��Center=�6W   $��2��6t   .+�5$   *   �� ��64   �� *FIO+5%   '   �� 5&   &   $ 
Horizontal=�61   $��1��6J   $��0��6W   .+�5'   *   �� ��64   �� *
Role.Title+5(   '   �� 5)   &   $ 
Horizontal=�61   $��1��6J   $��1��6W   .+�5*   *   �� 	 ��Name$	 editBtn��61   -   5        $ ��редактировать��5*   B   6Z   5+   '   5,   #   5-      5/      51      52      �� 53   
   $ 
Horizontal=�6   $��4��6.   .+�54      �� -   5        $	 AddBtn��54      $��Добавить��6%   68   55      �� 56   
   $ 
Horizontal=�6   $��0��6.   .+�57      �� -   5        
 ��Name$
 SerchTxb��57      $	��352��6K   �� 58      -   5        $��CmbRole��58      $	��243��6R   .@�59      �� .��6   Все6$   �� 5:      .��6   Сотрудники6+   �� 5;      .��6   ТимЛиды6(   �� 5<      .��6   Админы6'   5=      5>      5?      5@      