   M S B A M L   `   `   `  ����F  BResumeParse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ResumeParse.ViewModelResumeParse.ViewModel  5           ResumeParse.Views.validate   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ResumeParse.ViewModel     5        N� Title$  validate��5	      .��5      �  � RowDefinitions 5   
   �� 5      .+�5   
   �� $��Resume Parser��6   $��25(�5      
���i��$��	71,5,66,0q�5      $��Center=�5      $	��Top=�5      �� 5   
   -   5         ��Name$ 	listname1��5      $��10,43,10,189q�5      $��2q�5      ��5      ��  �� Path$ 
AllResumes���5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 ��ح�64   �� 5       � ��$ 1,1,1,1q�68   �� 5       � ��$ 2,0,0,0q�6/   �� 5        � ��$ Stretch=�6<   �� 5!       � ��$ Center=�6:   5#       �� View 5%      �� 5'      .P�5(      �� $
��Name��6%    �� Width$	 200��63   	 �� DisplayMemberBinding	 6?   �� $
 Name��� 5)      $��Email��6%   $	 200��64   	 6@   �� $ Email��� 5*      $��Phone��6%   $	 200��64   	 6@   �� $ Phone��� 5+      $��Summary��6%   $	 200��66   	 6B   �� $ Summary��� 5,      $��Skills��6%   $	 200��65   	 6A   �� $ Skills��� 5-      $��
Experience��6%   $	 200��69   	 6E   �� $ 
Experience��� 5.      $��	Education��6%   $	 200��68   	 6D   �� $ 	Education��� 5/      $��	Interests��6%   $	 200��68   	 6D   �� $ 	Interests��� 50      $��	Languages��6%   $	 200��68   	 6D   �� $ 	Languages�51      53      �� 55   
   -   5        $��parseBtn��55   8   $��Parse��6   $	��150��6H   $��1314,0,0,110q�6T   $
��Left=�6j   $��50��6�   $��Bottom=�6�   $��20(�6�   $
��Bold"�6�   �� 56   
   -   5        $��	selectBtn��56   ?   $��Select File��6   $	��151��6P   $��1147,0,0,110q�6\   $
��Left=�6r   $��50��6�   $��Bottom=�6�   $��20(�6�   $
��Bold"�6�   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   �� 57   
   -   5        $��multipleBtn��57   E   $��Multiple Select��6   $	��151��6X   $��1147,0,0,42q�6d   $
��Left=�6y   $��50��6�   $��Bottom=�6�   $��20(�6�   $
��Bold"�6�   $
 0.5,0.5&�6�   �� 58   
   -   5        $��exitBtn��58   6   $
��Exit��6   $	��150��6E   $��1314,0,0,42q�6Q   $
��Left=�6f   $��50��6�   $��Bottom=�6�   $��20(�6�   $
��Bold"�6�   �� 59   
   -   5        $��selectfileTB��59      $��33��6&   $��835,0,0,112q�62   $
��Left=�6G   $	��284��6b   $��Bottom=�6n   5:      5;      