   M S B A M L   `   `   `  ����   	Warehouse    Warehouse.View.MakeOrder   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  Создать заказ��$	��350��$	��350��   MakeOrderViewModel � DataContext# [   � 
ResizeMode$ NoResize=� � Icon$# /Warehouse;component/icon.png��.���  � RowDefinitions �� $	��22* ��� $
��119* ��� $
��172* ��� $	��59* � � ColumnDefinitions �� $	��15* ��� $
��115* ��� $
��214* �.+��� $��Контрагент��$
��Left=�$��	10,10,0,0q�$	��Top=�$��1��$��1��$��26��$	��100���� $ ��Ответственный��$
��Left=�$��	10,50,0,0q�$	��Top=�$��1��$��1��$��26��$	��100���� $��
Сумма��$
��Left=�$��10,1,0,0q�$	��Top=�$��1��$��2��$��26��$	��100���� $��Дата заказа��$
��Left=�$��	10,34,0,0q�$	��Top=�$��1��$��2��$��26��$	��100���� $��Дата привоза��$
��Left=�$��	10,74,0,0q�$	��Top=�$��1��$��2��$��26��$	��100���� $��Создать��$��2��$
��Left=�$��29��$��	13,10,0,0q�$��3��$	��Top=�$��82������ *	AddItem+�� $��Отмена��$��2��$
��Left=�$��29��$��
113,10,0,0q�$��3��$	��Top=�$��82������ *Exit+�� -   $��	txtIdUser��$��2��$
��Left=�$��	13,50,0,0q�$��1��$
��Wrap=�$	��Top=�$	��158��$��49������ *CurrentUser+�� -   $��txtIdContractor��$��2��$
��Left=�$��26��$��	13,10,0,0q�$��1�� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��137���� -   $��txtSumm��$��2��$
��Left=�$��26��$��13,1,0,0q�$��2��$
 Wrap=�$�� ��$	��Top=�$	��137���� -   $��txtDateOrder��$��2��$
��Left=�$��26��$��	13,36,0,0q�$��2��$
 Wrap=�$�� ��$	��Top=�$	��137���� -   $��txtDateImport��$��2��$
��Left=�$��26��$��	13,74,0,0q�$��2��$
 Wrap=�$�� ��$	��Top=�$	��137��