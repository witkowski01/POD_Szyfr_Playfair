   M S B A M L   `   `   `  ����M  IPOD_Szyfr_Playfair, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:POD_Szyfr_PlayfairPOD_Szyfr_Playfair  5   	   #    POD_Szyfr_Playfair.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   2local clr-namespace:POD_Szyfr_Playfair     5   	     � Title$  Konrad Witkowski��5   	   $	��736��6"   $
��1024��6/   ���	#FFA5FF09
���   �.��5      � $��	5,0,-5,29q�6   .+�5   
   �� $��-22,0,0,-30q�6   $��
Matrix.gif��6%   $
��Fill=�69   �� 5	   
   $��0,10,672,601q�6   $��Arial Black)�6*   $��22(�6C   $
��Bold"�6Q   ��5
      �� 5       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5      �  � Color$ DarkRed��6#    � Offset$ 3Q�63   � 5      $	 Red��6#   5      �� 5   %   $�Program ��6)   �� 6;   $� przedstawiający��6?   �� 6Y   �� 6e   $� działanie��6i   �� 6}   $� szyfru PLAYFAIR��6�   6�   �� 5   
   -   5         ��Name$ InstrukcjaButton��5      $��0,10,98,603q�6+   $��Right=�6@   $��88��6\   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   $��Instrukcja
VIDEO��6�   �� 5   
   -   5        $ Deszyfrowaniee��5      $��0,425,466,200q�6)   $��Right=�6@   $	��144��6\   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   .��6�   Deszyfrowanie6�   �� 5   
   -   5        $ Szyfrowaniee��5      $��0,425,768,200q�6'   $��Right=�6>   $	��146��6Z   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   .��6�   Szyfrowanie5      �� 5   
   -   5        $ Wczytaj��5      $��0,99,813,544q�6"   $��Right=�68   $	��164��6T   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   .��6�   Wczytaj z pliku6�   �� 5   
   -   5        $ Zapisz��5      $��0,99,518,544q�6!   $��Right=�67   $	��159��6S   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   .��6�   Zapisz do pliku6�   �� 5   
   -   5        $ Zamknij��5      $��0,632,30,10q�6"   $��Right=�67   $	��108��6S    J� RenderTransformOrigin$ 0.393,-3.722&�6m   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   .��6�   	Zamknij6�   �� 5   
   -   5        $ Minimalizuj��5      $��0,588,30,49q�6&   $��Right=�6;   $	��108��6W   $��Minimalizuj��6v   $ 0.702,1.308&�6�   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
grid_klucz��5      $��709,120,0,0q�6'   $	��Top=�6<   $ 0.531,0.576&�6T   $	��191��6x   	   HeadersVisibility$
	 None=�6�   $��16(�6�   $
��Left=�6�   $	��241��6�   �� 5   
   -	   5        
 ��Name$
 wejscie��5      $��37,137,418,0q�6#    �� TextWrapping$
 Wrap=�6:   $
��Left=�6N   $	��272��6i   $	��238��6u   $	��Top=�6�   .��6�    � DataContext 5      !   POD_Szyfr_Playfair.Playfair  5         wejscie$ wejscie��6!   .��5   #   5      �� 5!   
   -
   5        $
 wyjscie��5!      $��0,137,418,0q�6#   $
 Wrap=�68   $��Right=�6L   $	��272��6h   $	��238��6t   $	��Top=�6�   .��6�    5"        5#         wyjscie$ wyjscie��6!   .��5$   #   5%      �� 5&   
   -   5        $
 klucz��5&      $��406,10,418,639q�6!   $
 Wrap=�6:   ��6N   �� *klucz+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5'   
   $��37,62,894,582q�6   $��18(�6+   $
��Bold"�69   
���  ��
���   ��� 6p   $�Wejscie��6t   �� 6�   $�:��6�   6�   �� 5(   
   $��339,62,594,582q�6   $��18(�5)   
   $
��Bold"�6   
���  ��
���   ��� 6P   $�Wyjscie��6T   �� 6e   $�:��6i   6u   �� 5*   
   $��699,78,43,556q�6   $��18(�6+   $
��Bold"�69   
���  ��
���   ��� 6q   $$�Tablica szyfrowania(z kluczem)��6u   �� 6�   $� :��6�   6�   �� 5+   
   $��344,10,606,639q�6   $��18(�6-   $
��Bold"�6;   
���  ��
���   ��� 6s   $�Klucz��6w   6�     5,   
   -   5        $ grid_klucz_Copy��5,      $��709,392,0,0q�6,   $	��Top=�6A   $ 0.531,0.576&�6Y   $	��191��6}   $
	 None=�6�   $��16(�6�   $
��Left=�6�   $	��241��6�   �� 5-   
   $��699,328,43,290q�6   $��18(�6,   $
��Bold"�6:   
���  ��
���   ��� 6r   $%�Tablica z alfabetem dostępnym ��6v   �� 6�   �� 6�   $�podczas szyfrowania��6�   6�   r� 5.   
   -   5         r�Name$ MusicElement��5.       r� Source$ 	music.mp3?�6-   $��569,539,369,93q�6@   �� 5/   
   -   5        $ 
PlayButton��5/      $��0,593,352,49q�6%   $��Right=�6;   $	��108��6W   $ 0.393,-3.722&�6p   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   $��Music on��6�   �� 50   
   -   5        $ PlayButton_Copy��50      $��0,632,352,10q�6*   $��Right=�6@   $	��108��6\   $ 0.393,-3.722&�6u   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   $��
Music mute��6�   �� 51   
   -   5        $ InstrukcjaButton_Copy��51      $��0,10,210,603q�60   $��Right=�6F   $��88��6b   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   $��Instrukcja
OPISOWA��6�   �� 52   
   $��102,597,672,26q�6   $��18(�6,   $
��Bold"�6:   
���  ��
���   ��� 6r   $�Autor: Konrad Witkowski��6v   �� 6�   �� 6�   $�witkowski01��6�   6�   �� 53   
   -   5        $ AutorzyButton��53      $��0,593,522,20q�6(   $��Right=�6>   $��88��6Z   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   $��Autorzy��6�   �� 54   
   -   5        $ Wczytaj_key��54      $��0,42,522,601q�6&   $��Right=�6<   $��76��6X   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   $��KEY IN��6�   �� 55   
   -   5        $ 
Zapisz_key��55      $��0,42,418,601q�6%   $��Right=�6;   $��78��6W   ���	#FF22CF22$��16(�6�   $
��Bold"�6�   $��KEY OUT��6�   58      59      