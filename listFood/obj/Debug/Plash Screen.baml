   M S B A M L   `   `   `  ����C  ?listFood, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Test_Splash_ScreenTest_Splash_Screen  5   	   #    Test_Splash_Screen.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Test_Splash_Screen     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�6.    � WindowStyle$
 None=�6D    � Title$ Windows1��5   	   $	��450��6   $	��720��6'   $��./Font/#somefont)�5   	   .��5      � .+�5   
   ��  K� ZIndex$	 100��6   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth5=�6$    &  "MaterialDesignFloatingActionButton#��[  5   	   3  -MaterialDesignThemes.Wpf.ButtonProgressAssist   IsIndicatorVisible .    Value$ 75Q�5   	      IsIndeterminate . $��Loading��5   	   $��10(�6   $��
ExtraLight"�6)   $��40��6A   $��224,316,446,84q�6M   $��40��6e   	   IndicatorForeground	 �#AA381F
   Maximum$	
 100Q�5   L    J� RenderTransformOrigin$ 1.167,1.333&�5   	   
�������
���   �
�������6X   �� 5   
   $��/img/Untitled-1.png��6   �� 5   
   $��/img/Asset 3.png��6   $	��100��6*   $
��auto��66   $��440,164,180,194q�6D   �� 5   
   $��40(�6   $��412,91,160,312q�6"    �� TextAlignment$ Center=�6:   $��PHỞ��6Q   $��DemiBold"�6\   $��UVN Bo Quen)�6r   �� 5   
   $��Món ngon Việt Nam��6   $��396,268,116,136q�6,   $��20(�6E   $��DemiBold"�6S   6k   �� 5   
   $��20(�6   $��124,96,320,321q�6"   $ Center=�6:   $��Font/#Caveman)�6Q   $��WELCOME TO ��6l   �� 5   
   $��35(�6   $��126,130,318,278q�6"   $ Center=�6;   $��Font/#Caveman)�6R   $
��APP ��6m   �� 5   
   $��40(�6   $��112,206,318,122q�6"   $ Center=�6;   $��Font/#Caveman)�6R   �� 6n   $�FOOD ��6r   �� 6�   �� 6�   $�RECIPE��6�   6�   �� 5   
   -   5        $��Change��5   6   $#��Không hiển thị lần sau��6    d� 	IsChecked$ FalseY�6R   $��458,364,94,58q�6d   $
��Bold"�6{   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ Visible=�63    �� Triggers 5       �� 5!       �� Binding 6&   ��  �� ElementName$ CommentCheckBox�� �� Path$ 	IsChecked� �� Value True6f   .a�5"      ��  � y�$ Hidden=�6;   5#      5%      5'      5(      5)      