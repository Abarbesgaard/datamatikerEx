   M S B A M L   `   `   `  ����H  DDatamatikerEX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DatamatikerEXDatamatikerEX  5   	   K*clr-namespace:DatamatikerEX.MVVM.ViewModelDatamatikerEX.MVVM.ViewModel  5   	       DatamatikerEX.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DatamatikerEX     5   	   @	viewmodel*clr-namespace:DatamatikerEX.MVVM.ViewModel     5   	   $	��650��5	   	   $
��1200��5
   	   ���#36393f  � WindowStyle$
  None=�5   	    � AllowsTransparency .  � 
ResizeMode$ CanResizeWithGrip=�5   	    � DataContext 5      0   *DatamatikerEX.MVVM.ViewModel.MainViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��25 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   �� -   5        $��2��5      ���#252525._�5      � $��Stretch=�6   .+�5       �� $��Datamatiker UCL��6   
�������$��SemiBold"�5"      �� 5$      $��Right=�6    �� Orientation$ 
Horizontal=�5%      .+�5&      �� -   5        $��20��5&      $��20��5'      $
��🗕��5(      
������ $��0q�5*      
�������$��	ExtraBold"�5,      $��0,0,0,3q�5-      5.      �� 5/      -   5        $��20��5/      $��20��50      $	��▢��51      
������ $��0q�53      
�������$��	ExtraBold"�55      56      �� 57      -   5        $��20��57      $��20��58      $
��🗙��59      
������ $��0q�5;      
�������5=      5?      5A      5C      � 5E   
   ���#2f3136$��1��5F       5G      �� 5H      $��50 �6    �� 5I      �� 5J      $��60 �6    .+�5L      �� $��	Exercises��6   $��Center=�5M      $��Medium"�5N      
�������$��8,0,0,0q�5P      �� 5Q      
������ $��0q�5T      $��1��5U         	Exercises#��[  5V      ��5Q      �� *	Exercises+ �� SelectedItem 5R      �� *SelectedExercise+5V      �� 5X      $��2��6   $ 
Horizontal=�5Y      ���#292b2f.+�5[      ��  �� CornerRadius$ 25��6   $��30��5\      $��30��5]      ���#3bff6f$��18,0,0,0q�5_      �� 5`      $��Center=�6   .+�5a      �� 
�������$��SemiBold"�5c      $��	0,-5,0,-5q�5d      ��5a      �� *SelectedExercise.ExerciseName+5d      �� 5e      $��Status med opgaven��6   
�������$��Medium"�5g      $��10(�5h      $��	0,-8,0,-5q�5i      5k      5m      5n      � 5o   
   $��1��6   $��1��5p       5q      �� 5r      $��50 �6    �� 5s      .+�5u      �� ���#2f3136$��0,0,0,2q�5v      ._�5w      � $��Stretch=�6   $��8q�5x      .+�5y      �� 
�������$
��Bold"�5{      $��5,0,5,0q�5|      $��Center=�5}      ��5y      �� *SelectedExercise.ExerciseName+5}      �� 5~      $ 
Horizontal=�6!   $��Right=�5   !   .+�5�      �� $��Løst��6    
�������$��Center=�5�       �� 5�      $��Center=�6#   5�      5�      5�      �� 5�      
������ $��0q�5�        ExerciseItem#��[ 5�      $��8,0,0,0q�5�      $��1��5�      ��5�      �� *SelectedExercise.Messages+5�      5�      5�      5�      