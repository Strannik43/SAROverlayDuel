   M S B A M L   `   `   `  ���� K  GSAR Overlay Duel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SAR_Overlay_DuelSAR_Overlay_Duel  /    )SAR_Overlay_Duel.SpawnLobbySettingsWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:SAR_Overlay_Duel       � Title$  SpawnLobbySettingsWindow��$��50��$	��680�� � Topmost .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � AllowsTransparency .  J� Opacity$ 1Q� � 	Resources    FocusVisual �� Property �� Value	 �� StrokeDashArray
 J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground �� 
TargetType �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName�� %�  &	        &	 N     &	 c     &	 x     &	 �     &	 �     &	 �     &	 �     &	 �     &		 �     '��     7   7  7  7  7  7  7  7 	 �� .���  � �� �� .R��� $��2q�$		 1 2R�#��� ��
 . $��1���� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � �� �	#FF474747��  � ��
 �������  � ��
 �������  � ��$ 3q���  � ��$
 Bold"���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��$ 8��#��z��#��z��#��z��
 . ._��� $ contentPresenter��|�.  #��z��#��z����. #
 z
 #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border��8   � ���� $ border��8   � ��P�  � �� . . ��� $ border��8   � ���� $ border��8   � ��P�  � {� .  . ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ������  �� EndPoint$ 0.0,0&� �� 
StartPoint$ 1.0,0&�.���  � Offset$ 0Q�� $	 0.7Q� � Color$ 	#7FFFFFFF��� $ 	#BFACD2EC��$ 1Q�.���  � ColumnDefinitions �� $��50 ��� �� �� �� �� �� �� �� �� $��50 �.+��� -   $
��Left=�$��5,5,5,5q�$��9��.���� $��Resources/Arrow.png��$��3,0,0,0q��� -   $
��Left=�$��5,5,5,5q�$��0��.���� $��Resources/Arrow.png�� J� RenderTransformOrigin$ 0.5,0.5&�$��0,0,3,0q�z�V� .~��� �� ��  �� Angle$
 -180Q�T� �� -   $��Start��$
��Left=�$��6,5,0,5q�$��6��$��62���� $
��Stop��$
��Left=�$��6,5,0,5q�$��5��$��62���� -   $��Clear��$
��Left=�$��6,5,0,5q�$��4��$��62���� -   $��	Profile 1��$��Center=�$��0,5,0,5q�$��1��$��62���� -   $��	Profile 2��$
��Left=�$��6,5,0,5q�$��2��$��62���� $��	Profile 3��$
��Left=�$��6,5,0,5q�$��3��$��62��