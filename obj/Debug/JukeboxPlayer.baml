   M S B A M L   `   `   `  ����  Jukebox    Jukebox.JukeboxPlayer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  JukeboxPlayer��5   	   $	��450��6   $	��700��6,    � 	Resources 5         ImageSource1 �� CreateOptions �� CacheOption �� 	UriSource �� Rotation��%�   &	        �� 5   
   $ IgnoreImageCache=�6+   $ OnLoad=�6L   $E ?H:\private\CIS 310\final\Jukebox\Jukebox\images\background2.jpg?�6a   $ Rotate0=�6�   5      .��5      � ��5	   
   �� 5
       j� Stretch$
 Fill=�6    �� ImageSource# �   6(    j� 
AlignmentY$ Center=�6U   	 j� 
AlignmentX$	 Center=�6i   .+�5   
   �� -   5        
 ��Name$
 songListBox��5      $
��Left=�6'   $	��151��6B   $��	46,79,0,0q�6O   $	��Top=�6b   $	��183��6z    � Cursor$ UpArrow��6�   r� 5   
   -   5         r�Name$ mediaElement1��5       r� LoadedBehavior$ Manual=�6.    r� UnloadedBehavior$
 Stop=�6F   $
��Left=�6^   $��79��6y   $��	267,0,0,0q�6�   $	��Top=�6�   $	��127��6�   �� 5   
   -   5         ��Name$ 	deleteBtn��5      $��Remove from Playlist��6$   $
��Left=�6C   $��28��6^   $��267,174,0,0q�6j   $	��Top=�6   $	��127��6�   6�   �� 5   
   -   5        $ playBtn��5      $
��Play��6"   $
��Left=�61   $��28��6L   $��520,235,0,0q�6X   $	��Top=�6m   $��54��6�   6�   �� 5   
   -   5        $
 songListBox2��5      $
��Left=�6(   $	��151��6C   $��
455,79,0,0q�6P   $	��Top=�6d   $	��183��6|   6�   �� 5   
   -   5        $ addBtn��5      $��Add to Playlist��6!   $
��Left=�6;   $��30��6V   $��289,102,0,0q�6b   $	��Top=�6w   $��89��6�   6�   �� 5   
   $��1q�6   ._�5      �� -   5         ��Name$ imgBox��5      $
��Left=�6$   $	��186��6?   $��223,311,0,0q�6L   $	��Top=�6a   $	��252��6y   $y�Hidden=�6�   5      �� 5   
   -   5         ��Name$ yourPlaylistLbl��5      $��Playlist��6)   $��Center=�6<   $��31��6Y   $��514,43,49,0q�6e   $	��Top=�6z   $	��129��6�   
���r���$��16(�6�   $
��Bold"�6�   �� 5   
   -	   5        $ addPlaylistLbl��5      $D��>Click on a song then click
the add button to add
to playlist��6(   $��Center=�6�   $��64��6�   $��46,10,463,0q�6�   $	��Top=�6�   $	��183��6�   
���r���$��14(�6�   $
��Bold"�6  �� 5   
   -
   5        $ pauseBtn��5      $��Pause��6#   $
��Left=�63   $��28��6N   $��455,235,0,0q�6Z   $	��Top=�6o   $��54��6�   6�   �� 5   
   -   5        $ stopBtn��5      $
��Stop��6"   $
��Left=�61   $��28��6L   $��584,235,0,0q�6X   $	��Top=�6m   $��54��6�   6�   5      5      