   M S B A M L   `   `   `  ����P  LDockingLibrary, Version=0.1.5554.39456, Culture=neutral, PublicKeyToken=null/clr-namespace:DockingLibraryDockingLibrary  5      "    DockingLibrary.DocumentsPane   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      -customclr-namespace:DockingLibrary    5        � 	Resources  5         DocTabItemStyle �� 
TargetType �� Property �� Value ��Name �� CornerRadius �� EndPoint �� 
StartPoint � Color	 � Offset
 �� Color ��Name �� Triggers P� Property P� Value �� 
TargetName % !DocumentsTabSwitchMenuButtonStyle �� Stretch �� StrokeEndLineCap �� StrokeLineJoin   DocumentsTabCloseButtonStyle �� Padding  DocumentsTabControlTemplate �� 
TargetType �Name-  'System.Windows.Input.KeyboardNavigation   TabNavigation � ColumnDefinitions ��Name � RowDefinitions ��Name   TabIndex   DirectionalNavigation �� SelectedContent �� SelectedContentTemplate& �� SelectedContentTemplateSelector  � DataContext! ��Name" K� IsItemsHost# �� Orientation��%�  &	        &	 �    &	 8    &	 �    7  7  �� 5      " ��6!   .�5      ��  � �� 5      �� 5	      .R�5
      �� $ border��6g   -   5        $��Bottom=�5
      $��18��6*   $��1,1,1,0q�66   $ 4,4,0,0��6P   ��5   	   �� 5   
   $ 0.5,0.0&�6   $ 0.5,1&�61   .��5      � # � ��6   $	 0Q�6_   � 5      $ 	#FFFFFFFF��6   $	 1Q�6*   5      ��5   	   �� 5   
   #
 � ��6   ._�5   	   �� $ header��6e   #��z��6   $��2,0,0,0q�6T   6e   5   	    5      P� 5   	    �@��
IsSelected . . �5   
   �� $ border��6'    � �� 5      �� 5      #
 � ��6   5      �� 5   
   $ header��6>    � ��$
 Bold"�61   6>   5   
   5       5"      5#      �� 5%      " ��64   .�5&      ��  � �� 5'      �� 5(      .R�5)      �� $��18��6   ._�5*   	   F� $
 Fill=�6   ���	#FF000000$ Square=�60   $ Round=�6J   $��0��6a   $
��Auto��6u   "������- ��- �@]� ��- � z ��� 	$��3,6,3,3q�6�   ��5+   
   �� 5,      #
 � ��6   5.   
   5/   	   50      52      53      �� 55      " ��6/   .�56      ��  � �� 57      �� 58      .R�59      �� $��18��6   $ 0,1,0,1q�6   ._�5:   	   � .+�5;   
   F� ���	#FFFFFFFF$
 Fill=�6    ���	#FF000000$��3,3,3,3q�6B   ����        �@B @B 	6S   F� 5<   
   ���	#FFFFFFFF$
 Fill=�6    ���	#FF000000$��3,3,3,3q�6B   ����@B     �    @B 	6S   5=   
   5>   	   5?      5A      5B      �� 5D      " ��68   .R�5E      � $
 Grid��6
   $ Local=�6    5F      �� 5G      $ ColumnDefinition0��6   �� 5H      $ ColumnDefinition1��6   $��0 �63    5J      �� 5K      $ RowDefinition0��6   $
��Auto �6-   �� 5L      $ RowDefinition1��6   $��* �6-   .+�5N      �� $ ContentPanel��6*   $��1��6   $��0��6   ���	#FFD0CEBF$��0,0,1,1q�6X   $ 2��6r   $ Local=�6�   $ 	Contained=�6�   ._�5O      �� $ Border��6   #��z��6   #��z��6J   ._�5P      �� $ Border1��69   #��z��6   ._�5Q   	   �� $ PART_SelectedContentHost��6T   #��z��61   #��z 6v   #��z 6�   #��z 6�   $��SelectedContent��6*    6   Z� 6*  5R   	   5S      5T      �� 5U      $! HeaderPanel��6   $��0��6(   $��0��65   $��Stretch=�6E   $��Stretch=�6c   $��0,0,0,0q�6   $��Hidden=�6�   $��Disabled=�6�   ��5V      �� 5W      " ��6   .�5X   	   ��  � �� 5Y   
   �� 5Z      .R�5[      � $ HeaderPanel��6?   $��0,0,0,0q�6   $��0��6"   $��0��6/    5\      �� 5]      $��* �6   �� 5^      $��16 �6   �� 5_      $��16 �6    5a      �� 5b      $
��Auto �6   .+�5d      �� $��0��6$   #��z��64   �� 5e      -   5        $��1��5e      8��  5f      �� 5g      -   5        $��2��5g      8�� 6Z   5h      5i      5k      5l   
   .��5o      �� " . $# 
Horizontal=�6%   $ 1��6T   ��6>   Z� 6T   5p      5r      5s      5u      .��5v      � .+�5w      �� -   5        $��tbcDocuments��5w      $$ �� IsSynchronizedWithCurrentItem$
$ TrueY�6#   #���  6J   $y�	Collapsed=�6�   5x      5y      5z      