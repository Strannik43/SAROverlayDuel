   M S B A M L   `   `   `  ����K  GSAR Overlay Duel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SAR_Overlay_DuelSAR_Overlay_Duel  5   	   /    )SAR_Overlay_Duel.TournamentDuelInfoWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:SAR_Overlay_Duel     5   	     � Title$  TournamentDuelInfoWindow��5   	   $	��430��6*   $	��680��67    � 
ResizeMode$ NoResize=�6C    � AllowsTransparency .  � WindowStyle$
 None=�6s    � Topmost .  J� Opacity$ 1Q�6�    � 	Resources 5	         FocusVisual �� Property �� Value	 �� StrokeDashArray
 J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground �� 
TargetType �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName�� 5
   
   %}  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    '�� �    7   7  7  7  7  7  7  7 	 �� 5      .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6(   $		 1 2R�63   #��� ��6I   
 . $��1��6�   5      5      5      �� 5      $ 	#FFDDDDDD��6?   �� 5      $ 	#FF707070��6;   �� 5      $ 	#FFBEE6FD��6B   �� 5      $ 	#FF3C7FB1��6>   �� 5      $ 	#FFC4E5F6��6@   �� 5      $ 	#FF2C628B��6<   �� 5      $ 	#FFF4F4F4��6A   �� 5      $ 	#FFADB2B5��6=   �� 5      $ 	#FF838383��6A   �� 5      " ��6   .�5      ��  �@�FocusVisualStyle8   65   �� 5        � �� �	#FF4747476/   �� 5"       � ��
 �����60   �� 5$       � ��
 �����6/   �� 5%       � ��$ 3q�64   �� 5&       � ��$
 Bold"�6/   �� 5'       � ��$ Center=�6?   �� 5(       � ��$ Center=�6=   �� 5)       � ��$ 1q�6,   �� 5*       � �� 5+      �� 5,      " ��6*   .R�5-      �� $ border��6%   $ 8��65   #��z��6F   #��z��6p   #��z��6�   
 . ._�5.   "   �� $ contentPresenter��63   |�.  #��z��6_   #��z��6�   ��. #
 z
 6�   #��z��6  5/       50      P� 51   "    �@��IsDefaulted . . �52   &   �� $ border��6D   # � ��6X    � ��53   #   P� 54   "    �@J�IsMouseOver . . �55   &   �� $ border��6C   8   � ��6W   �� 56   &   $ border��6D   8   � ��6X   57   #   P� 58   "    � �� . . �59   &   �� $ border��6C   8   � ��6W   �� 5:   &   $ border��6D   8   � ��6X   5;   #   P� 5<   "    � {� .  . �5=   &   �� $ border��6C   8   � ��6W   �� 5>   &   $ border��6D   8   � ��6X   �� 5?   &   $ contentPresenter��6O   8   � ��6m   5@   #   5B      5D      5E      5F      ��5H      �� 5I   
    �� EndPoint$ 0.0,0&�6    �� 
StartPoint$ 1.0,0&�6/   .��5J      �  � Offset$ 0Q�6   � 5K      $	 0.7Q�6    � Color$ 	#7FFFFFFF��6(   � 5L      $ 	#BFACD2EC��6   $ 1Q�6-   5M      .��5O      � .+�5P   
   �� -   5         ��Name$ ListBoxPlayers��5P      $��	0,0,340,0q�6*   ���	#FF474747
�������
�������6l   �� 5Q   
   -   5        $ ListBoxPlayers2��5Q      $��	340,0,0,0q�6+   ���	#FF474747
�������
�������6�   5R      5S      