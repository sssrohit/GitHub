   M S B A M L   `   `   `  ����F  BResumeParse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ResumeParse.ViewsResumeParse.Views  5   
       ResumeParse.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   1localclr-namespace:ResumeParse.Views     5   
     � WindowStartupLocation$  CenterScreen=�5   	    � Title$+ %Resume Parser | Super Simple Software��5   	   $	��500��67   $
��1500��6D    � DataContext 5	      �� 5
   
    �� Path$
 Main�6      Locator �� Source# [  6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      6"   �� 5      6"   �� 5      6"    � ColumnDefinitions 5      5      �� 5   
   $��0��6   $��0��6"    �� Orientation$ 
Horizontal=�62   $��50��6K   $	��Top=�6W   $��	20,30,0,0q�6o   .+�5       �� -   5        $
��Load��5       $	��100��6$   $��20(�6H   $
��Bold"�6V   $	��150��6h   �� 5!      -   5        $��
Validation��5!      $	��100��6*   $��10,0,0,0q�6:   $��20(�6c   $
��Bold"�6q   $	��150��6�   �� 5"      -   5        $��Search��5"      $	��100��6&   $��10,0,0,0q�65   $��20(�6G   $
��Bold"�6U   $	��150��6g   6s   5#      $   ResumeParse.Views.UCNewResumes  5$   
   $��0��6   $��10,118,00,0q�6-    � 5%   
   -   5          �Name$
 Main��5%      $��0,80,0,0q�6   	  � NavigationUIVisibility$	 Hidden=�60   5'      5(      