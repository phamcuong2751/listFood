   M S B A M L   `   `   `  ����C  ?listFood, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Test_Splash_ScreenTest_Splash_Screen  5   	       listFood.Home   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Test_Splash_Screen     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5           MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$
 Home��5   	   $	��450��6   $	��850��6#   .��5      �� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�5      $��16q�5      $	��843��6   ���#AA381F.��5      ]� .+�5      ��  �� Orientation$ 
Horizontal=�5      +  %MaterialDesignThemes.Wpf.RippleAssist   
IsCentered . .+�5        $ Standard=�5   	   $��8 4 8 4q�5   	      CornerRadius$ 20��5    	    K� ZIndex$ 1��5!   	   $��16 0 0 0q�5"   	   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5#   	   $	��374��6:   .��5$      � 	 � RowDefinitions	 5%      �� 5&   "   $	��19* �60   �� 5'   "   $	��13* �60   
 � ColumnDefinitions
 5)      �� 5*   "   $
��Auto �5+      �� 5,   "   $��* �5-      �� 5.   "   $
��Auto �5/      .+�51      ��   MaterialDesignToolButton#���  52      $��2��6@   .��53   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Magnify=�54       J� Opacity$	 .56Q�55      $��22��6   $��22��6)   56      �� 57      $��1��58      $��8,4,0,4q�59      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$2 ,Nhập từ khoá để tìm công thức...��5:      .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5;      $��0q�5<      $	��200��5=      $��Center=�5>      $��2��6(   5@      5A      5C      5D      5E      A� 5G   
   $	��120��6   $	��120��6   $��Center=�6+   $��Bottom=�6H   ���#AA381F �� Left$ 62��5H   !   
 �� Top$ 94��62   A� 5I   
   $	��120��6   $	��120��6   $��Center=�6+   $��Bottom=�6H   ���#AA381F$ 70��5J   !   $	 261��62   �� 5L   
   $��/img/Canh.png��6   $	��120��6'   $	��120��64   $��Center=�6@   $��Bottom=�6]   $ 70��6x   $ 94��6�   �� 5M   
   $��/img/Vit_nuong.png��6   $	��120��6,   $	��120��69   $��Center=�6E   $��Bottom=�6b   $ 78��6}   $	 261��6�   �� 5O   
   $��/img/star-1.png��6   $��30��6)   $	 167��65   $	 261��6G   �� 5P   
   $��img/star-1.png��6   $��30��6(   $	 167��64   $ 94��6F   �� 5Q   
   -   5        $��	howToFood��5Q      $	��109��6#   $	 364��60    �� TextWrapping$
 Wrap=�6B   $��TextBox��6V   $	 151��6e   $	��317��6v   5T      5U      