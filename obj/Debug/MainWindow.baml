   M S B A M L   `   `   `  ����  Jukebox    Jukebox.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��325��6   $	��400��6)    � 	Resources 5         ImageSource1 �� CreateOptions �� CacheOption �� 	UriSource��%�   &	        �� 5   
   $ IgnoreImageCache=�6+   $ OnLoad=�6L   $C =H:\private\CIS 310\final\Jukebox\Jukebox\images\backround.jpg?�6a   5      .��5      � $��
0,18,0,-18q�6   ��5	   
   �� 5
       j� Stretch$
 None=�6    �� ImageSource# �   6(    j� 
AlignmentY$	 Top=�6U    j� 
AlignmentX$ Center=�6f   	 � ColumnDefinitions	 5   
   �� 5      $��0* �6   �� 5      .+�5   
   �� -   5        
 ��Name$
 
usernameTB��5      $
��Left=�6&   $��29��6A   $��
207,70,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��119��6�   $��2��6�   G� 5   
   -   5         G�Name$ 
passwordTB��5      $
��Left=�6*   $��29��6E   $��207,141,0,0q�6Q   $	��Top=�6f   $	��119��6~   $��2��6�   �� 5   
   -   5         ��Name$ loginBtn��5      
������ 
���P��$��Login��6O   $
��Left=�6_   $��30��6z   $��207,197,0,0q�6�   $	��Top=�6�   $	��119��6�   $��2��6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ usernameLbl��5      $
��Left=�6%   $��29��6@   $��	82,70,0,0q�6L   $	��Top=�6_   $	��110��6w   
�������$��2��6�   $��	Username:��6�   $��16(�6�   �� 5   
   -   5        $ errorLbl��5      $��Error��6"   $
��Left=�62   $��37��6M   $��
302,99,0,0q�6Y   $	��Top=�6m   $	��136��6�   $y�Hidden=�6�   $��2��6�   �� 5   
   -   5        $ 
jukeboxBtn��5      $��2��6%   $��Jukebox��69   $
��Left=�6K   $��46��6f   $��
23,215,0,0q�6r   $	��Top=�6�   $��80��6�   $y�Hidden=�6�   �� 5   
   -   5        $��textBlockHeading��5   M   $��50��6   $
��Left=�6    $��24,7,0,0q�6;   $	��Top=�6e   $��12(�6}   $��Italic$�6�   
������� �� Padding$ 5q�6�   $��2��6�   75Please login here to use the Jukebox.. If you are not�� 5   D   )'a registered user then please click on �� 5      �� 5      -   5        $��14(�5   ;   
����� �$��Normal$�6[   .�6n   
Register6x   5      	 button5      �� 5    
   -	   5        $ adminLoginBtn��5       
������ 
���P��$��2��6T   $��Admin Login��6h   $
��Left=�6~   $��30��6�   $��
67,197,0,0q�6�   $	��Top=�6�   $	��112��6�   $
��Bold"�6�   �� 5!   
   -
   5        $��bottom��5!   ;   $��50��6   $
��Left=�6    $��14(�6I   $��Italic$�6W   
�������$��2��6~   $��
32,243,0,2q�6�   42Unregistered users click here to play the Jukebox �� 5$      �� 5%      -   5        $��14(�5%   ;   
����� �$��Normal$�6[   .�6n   Login6u   5&      5)      �� 5*   
   -   5        $ passwordLbl��5*      $
��Left=�6%   $��29��6@   $��
82,141,0,0q�6L   $	��Top=�6`   $	��110��6x   
�������$��2��6�   $��	Password:��6�   $��16(�6�   5,      5-      