   M S B A M L   `   `   `  ����M  IPOD_Szyfr_Playfair, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:POD_Szyfr_PlayfairPOD_Szyfr_Playfair  5   	   $    POD_Szyfr_Playfair.Instrukcja2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   2local clr-namespace:POD_Szyfr_Playfair     5   	     � Title$  
Instrukcja��5   	   $��700.09��6   $��1020.112��6,   ���	#FFA5FF09
���   �.��5      � $��5,0,-254,-161q�6    � ColumnDefinitions 5   
   �� 5      $
��483* �6   �� 5	      $
��134* �6   .+�5   
   �� $��-285,-58,-38,-209q�6   $��
Matrix.gif��6+   $
��Fill=�6?   $��2��6N   �� 5   
   $��10,9,778,779q�6   $��Arial Black)�6*   $��22(�6C   $
��Bold"�6Q   $��
INSTRUKCJA��6c   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5      �  � Color$ DarkRed��6#    � Offset$ 3Q�63   � 5      $	 Red��6#   5      5   &   �� 5   
   -   5         ��Name$ Minimalizuj��5      $��0,588,23,187q�6&   $��Right=�6<   $	��108��6X   $��Minimalizuj��6w    J� RenderTransformOrigin$ 0.702,1.308&�6�   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $ Zamknij��5      $��0,588,152,187q�6"   $��Right=�69   $	��108��6U   $ 0.393,-3.722&�6o   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   $��Zamknij��6�   �� 5   
   $��10,173,721,398q�6   $��
Image2.png��6(   $
��Fill=�6<   �� 5   
   $��10,92,700,678q�6   $��18(�6+   $
��Bold"�69   
���  ��
���   ��� 6q   $#�Umieszczamy klucz w tablicy w��6u   �� 6�   �� 6�   $�następujący sposób:��6�   6�   �� 5   
   $��10,46,686,743q�6   $��18(�6+   $
��Bold"�69   
���  ��
���   �$$��Klucz w przykładzie : KEYWORD��6p   �� 5   
   $��31,438,722,287q�6   $��18(�6,   $
��Bold"�6:   
���  ��
���   ��� 6r   $�Jak widać wpisujemy��6v   �� 6�   �� 6�   $� pojedyncze litery bez��6�   �� 6�   �� 6�   $� powt��6�   �� 6�   $�ó��6�   �� 6�   $�
rzeń, i u��6�   �� 6  $�z��6  �� 6  $�
upełniamy��6  �� 6.  �� 6:  $� alfabet do końca ��6>  6[  �� 5   
   $��319,121,418,678q�6   $��18(�6-   $
��Bold"�6;   
���  ��
���   �$��Szyfrowane słowo:  WORD��6r   �� 5   
   $��318,173,418,601q�6   $��18(�6-   $
��Bold"�6;   
���  ��
���   ��� 6s   $#�Słowo dzielimy na pary liter��6w   �� 6�   �� 6�   $�WO  RD��6�   �� 6�   �� 6�   6�   �� 5   
   $��317,257,419,506q�6   $��18(�6-   $
��Bold"�6;   
���  ��
���   ��� 6s   $�Literki po zamianie��6w   �� 6�   �� 6�   $�OK   DA��6�   �� 6�   6�   �� 5   
   $��318,334,389,365q�6   $��18(�6-   $
��Bold"�6;   
���  ��
���   ��� 6s   $#�Pary liter możemy podzielić��6w   �� 6�   �� 6�   $� na trzy grupy:��6�   �� 6�   �� 6�   $�-��6�   �� 6�   $$�litery są w tym samym wierszu��6�   �� 6  �� 6  $�-��6  �� 6&  $%�litery są w tej samej kolumnie��6*  �� 6R  �� 6^  $�-��6b  �� 6m  $�
pozostałe��6q  6�  �� 5   
   $��675,56,40,663q�6   $��18(�6+   $
��Bold"�69   
���  ��
���   ��� 6q   $'�!Jeśli litety leżą w tym samym ��6u   �� 6�   �� 6�   $�wierszu zastępujemy je ��6�   �� 6�   �� 6�   $(�"sąsiadującymi z nimi literami z ��6�   �� 6  �� 6  $�prawej strony��6  60  �� 5   
   $��667,192,0,554q�6   $��18(�6+   $
��Bold"�69   
���  ��
���   ��� 6q   $�Jeśli litety leżą w ��6u   �� 6�   $�tej samej kolumnie ��6�   �� 6�   �� 6�   $�powinny zostać��6�   �� 6�   $� ��6�   �� 6�   $�zastąpione ��6�   �� 6  �� 6  $�przez litery leżące pod��6  �� 65  $� ��69  �� 6D  $� nimi��6H  �� 6W  $�.��6[  6g  �� 5   
   $��637,298,0,287q�6   $��18(�6+   $
��Bold"�69   
���  ��
���   ��� 6q   $+�%w innych wypadkach:  aby zaszyfrować��6u   �� 6�   �� 6�   $+�% pierwszą literę, idziemy wzdłuż ��6�   �� 6�   �� 6�   $(�"wiersza, aż dotrzemy do kolumny, ��6�   �� 6  �� 6%  $.�(która zawiera drugą literę. Litera na��6)  �� 6X  �� 6d  $�krzyżowaniu��6h  �� 6}  $� ��6�  �� 6�  $�wiersza z kolumną ��6�  �� 6�  �� 6�  $%�zastępuje pierwszą literę. W��6�  �� 6�  $� ��6�  �� 6�  $�celu ��6�  �� 6  �� 6  $-�'zaszyfrowania drugiej z liter, szukamy ��6  �� 6E  �� 6Q  $*�$wzdłuż wiersza kolumny, w której ��6U  �� 6�  �� 6�  $�znajduje się��6�  �� 6�  $� ��6�  �� 6�  $�pierwsza litera. Znak ze��6�  �� 6�  �� 6�  $� ��6�  �� 6�  $�s��6�  �� 6  $/�)krzyżowania reprezentuje drugą literę.��6	  6:  5!      5"      