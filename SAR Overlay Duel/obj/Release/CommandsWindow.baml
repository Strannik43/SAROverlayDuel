   M S B A M L   `   `   `  ���� K  GSAR Overlay Duel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SAR_Overlay_DuelSAR_Overlay_Duel  %    SAR_Overlay_Duel.CommandsWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:SAR_Overlay_Duel       � Title$  CommandsWindow��$	��480��$	��384�� � Topmost .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � AllowsTransparency .  J� Opacity$ 1Q� � 	Resources    FocusVisual �� Property �� Value	 �� StrokeDashArray
 J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground �� 
TargetType �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName 

 Pistol  DualPistols 
 Magnum 
 Deagle  SilencedPistol  Shotgun  JAG7  SMG  	ThomasGun  AK  M16  DognasDartGun  DartFly  HuntingRifle 
 Sniper  SuperiteLaser  Minigun  Bow  SparrowLauncher  BCG  Cupgrade  BananaForker   SuperBandoiler ! 	ClawBoots " NinjaBooties # ImposibleTape $ SkunkGasSnorkel % SuperJuicer 
& banana 
' armor1 
( armor2 
) armor3 	* juice + tape , None - LittleBullets . 
BigBullets / SniperBullets 
0 Shells 1 SpecialtyAmmo 2 SuperiteCartridges�� %^  &	        &	 N     &	 c     &	 x     &	 �     &	 �     &	 �     &	 �     &	 �     &		 �     '��     7   7  7  7  7  7  7  7 	 &	
    &	 A   &	 k   &	 �   &	 �   &	 �   &	    &	 @   &	 f   &	 �   &	 �   &	 �   &	    &	 +   &	 S   &	 |   &	 �   &	 �   &	 �   &	    &	 4   &	 V   &	  |   &	! �   &	" �   &	# �   &	$ )   &	% O   &	& t   &	' �   &	( �   &	) �   &	* �   &	+ 	   &	, ?	    &	- D	   &	. k	   &	/ �	   &	0 �	   &	1 �	   &	2 

   �� .���  � �� �� .R��� $��2q�$		 1 2R�#��� ��
 . $��1���� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � �� �	#FF474747��  � ��
 �������  � ��
 �������  � ��$ 3q���  � ��$
 Bold"���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��$ 8��#��z��#��z��#��z��
 . ._��� $ contentPresenter��|�.  #��z��#��z����. #
 z
 #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border��8   � ���� $ border��8   � ��P�  � �� . . ��� $ border��8   � ���� $ border��8   � ��P�  � {� .  . ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ���� $#��Resources/gun_pistol_grey.png���� $$��Resources/gun_dualies_grey.png���� $#��Resources/gun_magnum_grey.png���� $#��Resources/gun_deagle_grey.png���� $,��&Resources/gun_silenced_pistol_grey.png���� $$��Resources/gun_shotgun_grey.png���� $!��Resources/gun_jag7_main.png���� $ ��Resources/gun_smg_grey.png���� $#��Resources/gun_thomas_grey.png���� $��Resources/gun_ak_grey.png���� $ ��Resources/gun_m16_grey.png���� $!��Resources/gun_dart_grey.png���� $$��Resources/gun_dartfly_grey.png���� $"��Resources/gun_rifle_grey.png���� $#��Resources/gun_sniper_grey.png���� $!��Resources/SuperiteLaser.png���� $$��Resources/gun_minigun_grey.png���� $#��Resources/gun_bow_default.png���� $��Resources/sparrow.png���� $��Resources/bcg.png���� $��Resources/cupgrade.png���� $ ��Resources/bananaforker.png���� $$��Resources/attach-bandolier.png���� $$��Resources/attach-clawshoes.png���� $%��Resources/attach-ninjashoes.png���� $(��"Resources/attach-tapedispenser.png���� $ ��Resources/skunkshorkel.png���� $��Resources/SuperJuicer.png���� $��Resources/banana.png���� $��Resources/armor1lvl.png���� $��Resources/armor2lvl.png���� $��Resources/armor3lvl.png���� $��Resources/juice.png���� $��Resources/SuperTape.png���� �� $!��Resources/ammo_pistolUI.png���� $ ��Resources/ammo_rifleUI.png���� $!��Resources/ammo_sniperUI.png���� $"��Resources/ammo_shotgunUI.png���� $$��Resources/ammo_specialtyUI.png���� $&�� Resources/SuperiteCartridges.png������  �� EndPoint$ 0.0,0&� �� 
StartPoint$ 1.0,0&�.���  � Offset$ 0Q�� $	 0.7Q� � Color$ 	#7FFFFFFF��� $ 	#BFACD2EC��$ 1Q�.��� -    � ColumnDefinitions �� �� �� �� ��  � RowDefinitions �� �� �� �� �� �� �� �� �� �� .+��� $��MatchID��$��0��$��0��
 � Tag$ matchid���� $��Gasoff��$��1��$��0��$ gasoff���� $��Night��$��4��$��3��$ night���� $��
Getplayers��$��3��$��0��$ 
getplayers���� $��Gasstart��$��1��$��1��$ gasstart���� $��Onehits��$��0��$��1��$ onehits���� $��Noroll��$��3��$��3��$ noroll���� $
��Rain��$��2��$��1��$
 rain���� $
��Pets��$��3��$��1��$
 pets���� $��Moles��$��4��$��1��$ moles���� $��Armors��$��0��$��2��$ onehits���� $��
Throwables��$��1��$��2��$ 
throwables���� $
��Guns��$��2��$��2��$
 guns���� $��Allitems��$��3��$��2��$ allitems���� $��Moles��$��4��$��2��$ moles���� $��Utils��$��0��$��3��$ utils���� $
��Emus��$��1��$��3��$
 emus���� $��Allitems��$��4��$��0��$ allitems���� $��Startp��$��2��$��0��$ startp���� $��God All��$��2��$��3��$ god all��