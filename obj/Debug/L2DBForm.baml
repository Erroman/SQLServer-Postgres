   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      V RSystem.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089J6clr-namespace:System.Xml.Linq;assembly=System.Xml.LinqSystem.Xml.Linq 5      > :app, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LinqToXmlDataBindingLinqToXmlDataBinding 5      $   LinqToXmlDataBinding.L2XDBForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      9system&clr-namespace:System;assembly=mscorlib     5      Hxlinq6clr-namespace:System.Xml.Linq;assembly=System.Xml.Linq     5      4local"clr-namespace:LinqToXmlDataBinding     5        � Title$(  "WPF Data Binding using LINQ-to-XML��5      $	��665��60   $	��500��6=    � 
ResizeMode$ NoResize=�6I    � 	Resources 5	         LoadedBooks S� 
ObjectType  System.Xml.Linq.XElement S� 
MethodName S� MethodParameters!  System.Xml.Linq.LoadOptions  BookTemplate �� Orientation �� Path��%5  &	        &	 7    S� 5   
   "  61   $ Parse��6V    5      ��5      ��
<books xmlns="http://www.mybooks.com">
  <book id="0">book zero</book>
  <book id="1">book one</book>
  <book id="2">book two</book>
  <book id="3">book three</book>
</books>
��5       5      PreserveWhitespace=�68   5      �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� $��3q�6   ��6'   �� $ Attribute[id].Value��� 5      $��3q�6   $��-��6'   �� 5       $��3q�6   ��6'   �� $ Value�5!      5"      5#      .��5&      �� 
����ح� � DataContext 6(   �� 	 �� Source#	 [  .+�5(   
   ]� $��5q�6   .+�5)      �� 
�������$��12(�6'   
���   �$��1q�6I   $
��Bold"�6]   .��6o   XML
 � LayoutTransform
 5*      �� 5+       �� Angle$ 90Q�6"   5-      �� 5.      -   5        $��tbRawXml��5.      $	��200��6(   
�������$��CharacterEllipsis=�6f   ��6L   �� $	 Xml�6f   5/      �� 51   
   $��4��6   $��5q�6   ]� 54   
   $��5q�6   .+�55      �� 
�������$��12(�6'   
���   �$��1q�6I   $
��Bold"�6]   .��6o   	Book List
 56      �� 57      $ 90Q�6&   59      �� 5:      -   5        $��lbBooks��5:      $	��200��6%   $	��415��62   #��[ 6>   ��5;      �� 5<      $, &Elements[{http://www.mybooks.com}book]�6   5>      �� 5?      -   5        $��5q�5?      $��Right=�6    $��30��67   $	��130��6C   $��Remove Selected Book��6P   
 5@      �� 5A      $ 90Q�6"   5C      5D      �� 5F   
   $��4��6   $��5q�6   ]� 5I   
   $��5q�6   .+�5J      �� $��5q�6   $��30��6#   $��65��6/   $��Right=�6:   
�������$
��Wrap=�6h    �� TextAlignment$ Center=�6|   Changes are live!
 5L      �� 5M      $ 90Q�6&   5O      �� 5P      .+�5Q      �� $	��450��6   
�������$��12(�66   
���   �$��1q�6X   $
��Left=�6l   $
��Bold"�6�   .��6�   Edit Selected Book6�   �� 5R      $��1q�6    6(   ��  �� ElementName$ lbBooks��$ SelectedItem�.+�5S      �� $ 
Horizontal=�6!   .+�5T      �� $��40��6    .��6+   ID:60   �� 5U      -   5        $��editAttributeTextBox��5U   "   $	��410��6>   ��6J   �� $ Attribute[id].Value�.��6t    � ToolTip 5V      �� 5W   "   $
��Bold"�6,   $ Center=�6>   �� 5X   &   .��6,   /-Edit the selected book ID and see it changed.6[   5Y   #   .��5Z   /   5[      5\      �� 5]      $ 
Horizontal=�6!   .+�5^      �� $��40��6    .��6+   Value:63   �� 5_      -   5        $��editValueTextBox��5_   "   $	��410��6:   $��25��6b   ��6F   �� $ Value�.��6n    5`      �� 5a   "   $
��Bold"�6,   $ Center=�6>   �� 5b   &   .��6,   20Edit the selected book Value and see it changed.6^   5c   #   .��5d   /   5e      5f      5g      5h      5i      �� 5k   
   $��4��6   $��5q�6   ]� 5n   
   $��5q�6   .+�5o      �� -   5        $��5q�5o      $��30��6    $��Right=�6,   .��6V   
Add Book
 5p      �� 5q      $ 90Q�6&   5s      �� 5t      .+�5u      �� $	��450��6   
�������$��12(�66   
���   �$��1q�6X   $
��Left=�6l   $
��Bold"�6�   .��6�   Add New Book6�   �� 5v      $��1q�6   .+�5w      �� $ 
Horizontal=�6!   .+�5x      �� $��40��6    .��6+   ID:60   �� 5y      -   5        $��tbAddID��5y   "   $	��410��61   .��6=    5z      �� 5{   "   $
��Bold"�6,   $ Center=�6>   �� 5|   &   .��6,   64Enter a book ID and Value pair, then click Add Book.6b   5}   #   .��5~   /   5      5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��40��6    .��6+   Value:63   �� 5�      -   5        $��
tbAddValue��5�   "   $	��410��64   $��25��6@   .��6L    5�      �� 5�   "   $��	UltraBold"�6,   $ Center=�6C   �� 5�   &   .��6,   64Enter a book ID and Value pair, then click Add Book.6b   5�   #   .��5�   /   5�      5�      5�      5�      5�      5�      5�      