   M S B A M L   `   `   `  ����  PasswordResetBruteForce!    PasswordResetApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Password Reset Tool��5   	   $	��350��6%   $	��525��62   .��5      � .+�5   
   �� $��Enter Password:��6   $
��Left=�6*   $	��Top=�6E   $��	10,10,0,0q�6]   �� 5   
   -   5        $��txtPassword��5      $
��Left=�6%   $	��Top=�6@   $��
150,10,0,0q�6X   $	��200��6l   �� 5   
   -   5        $��
btnEncrypt��5      $��Encrypt Password��6#   $
��Left=�6>   $	��Top=�6Y   $��	10,40,0,0q�6q   $	��120��6�   6�   �� 5
   
   $��Stored Password:��6   $
��Left=�6+   $	��Top=�6F   $��	10,70,0,0q�6^   �� 5   
   -   5        $��txtStoredPassword��5      $
��Left=�6+   $	��Top=�6F   $��
150,70,0,0q�6^   $	��200��6r    �� 
IsReadOnly$
 True��6~   �� 5   
   $��Execution Time:��6   $
��Left=�6*   $	��Top=�6E   $��
10,100,0,0q�6]   �� 5   
   -   5        $��txtExecutionTime��5      $
��Left=�6*   $	��Top=�6E   $��150,100,0,0q�6]   $	��200��6r   $
 True��6~   �� 5   
   $��Brute-Forced Salt:��6   $
��Left=�6-   $	��Top=�6H   $��
10,130,0,0q�6`   �� 5   
   -   5        $��txtBruteForcedPassword��5      $
��Left=�60   $	��Top=�6K   $��150,130,0,0q�6c   $	��200��6x   $
 True��6�   �� 5   
   $��Number of Threads:��6   $
��Left=�6-   $	��Top=�6H   $��
10,160,0,0q�6`   �� 5   
   -   5        $��txtNumThreads��5      $
��Left=�6'   $	��Top=�6B   $��150,160,0,0q�6Z   $��50��6o   �� 5   
   -   5        $��btnBruteForce��5      $��Brute Force Password��6&   $
��Left=�6E   $	��Top=�6`   $��
10,200,0,0q�6x   $	��150��6�   6�   5      5      