   M S B A M L   `   `   `  ����E  AFactoryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FactoryApp.UserControlsFactoryApp.UserControls  5      #    FactoryApp.UserControls.Lines   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:FactoryApp.UserControls     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��1��5      $	��200��6       AutoGenerateColumns .     
IsReadOnly . ��6-   �� *Lines+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+  5      $
 Name��6%    63   �� *Name+  5      $ Productivity��6%    6;   �� *ProductivityString+  5      $ Description��6%    6:   �� *Description+5      �� 5   
   -   5         ��Name$
 Back��5      $��2��6   $
��Back��6,   $��40��6;   $��4q�6F   $
��Left=�6Q   6l   5      5      