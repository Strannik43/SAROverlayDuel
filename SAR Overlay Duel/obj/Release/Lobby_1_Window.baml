   M S B A M L   `   `   `  ���� K  GSAR Overlay Duel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SAR_Overlay_DuelSAR_Overlay_Duel  %    SAR_Overlay_Duel.Lobby_1_Window   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:SAR_Overlay_Duel       � Title$  Lobby_1_Window��$	��430��$	��680�� � Topmost .  � WindowStyle$
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
StartPoint$ 1.0,0&�.���  � Offset$ 0Q�� $	 0.7Q� � Color$ 	#7FFFFFFF��� $ 	#BFACD2EC��$ 1Q�.��� -   .+��� $��Resources/lobby1.jpg���� -    ��Name$ Left1��$
��Left=�$��
247,56,0,0q�$��36��$��36��$	��Top=�
 � Tag$ 0���� -   $ Left2��$
��Left=�$��
247,97,0,0q�$��36��$��36��$	��Top=�$ 1���� -   $ Left3��$
��Left=�$��247,138,0,0q�$��36��$��36��$	��Top=�$ 2���� -   $ Left4��$
��Left=�$��247,179,0,0q�$��36��$��36��$	��Top=�$ 3���� -   $ Left5��$
��Left=�$��247,220,0,0q�$��36��$��36��$	��Top=�$ 4���� -   $ Left6��$
��Left=�$��247,261,0,0q�$��36��$��36��$	��Top=�$ 5���� -   $ Left7��$
��Left=�$��
304,56,0,0q�$��36��$��36��$	��Top=�$ 6���� -	   $ Left8��$
��Left=�$��
304,97,0,0q�$��36��$��36��$	��Top=�$ 7���� -
   $ Left9��$
��Left=�$��304,138,0,0q�$��36��$��36��$	��Top=�$ 8���� -   $ Left10��$
��Left=�$��304,179,0,0q�$��36��$��36��$	��Top=�$ 9���� -   $ Left11��$
��Left=�$��304,220,0,0q�$��36��$��36��$	��Top=�$ 10���� -   $ Left12��$
��Left=�$��304,261,0,0q�$��36��$��36��$	��Top=�$ 11���� -   $ Right1��$
��Left=�$��
366,56,0,0q�$��36��$��36��$	��Top=�$ 12���� -   $ Right2��$
��Left=�$��
366,97,0,0q�$��36��$��36��$	��Top=�$ 13���� -   $ Right3��$
��Left=�$��366,138,0,0q�$��36��$��36��$	��Top=�$ 14���� -   $ Right4��$
��Left=�$��366,179,0,0q�$��36��$��36��$	��Top=�$ 15���� -   $ Right5��$
��Left=�$��366,220,0,0q�$��36��$��36��$	��Top=�$ 16���� -   $ Right6��$
��Left=�$��366,261,0,0q�$��36��$��36��$	��Top=�$ 17���� -   $ Right7��$
��Left=�$��
426,56,0,0q�$��36��$��36��$	��Top=�$ 18���� -   $ Right8��$
��Left=�$��
426,97,0,0q�$��36��$��36��$	��Top=�$ 19���� -   $ Right9��$
��Left=�$��426,138,0,0q�$��36��$��36��$	��Top=�$ 20���� -   $ Right10��$
��Left=�$��426,179,0,0q�$��36��$��36��$	��Top=�$ 21���� -   $ Right11��$
��Left=�$��426,220,0,0q�$��36��$��36��$	��Top=�$ 22���� -   $ Right12��$
��Left=�$��426,261,0,0q�$��36��$��36��$	��Top=�$ 23���� -   $ Down1��$
��Left=�$��211,336,0,0q�$��36��$��36��$	��Top=�$ 24���� -   $ Down2��$
��Left=�$��254,336,0,0q�$��36��$��36��$	��Top=�$ 25���� -   $ Down3��$
��Left=�$��297,336,0,0q�$��36��$��36��$	��Top=�$ 26���� -   $ Down4��$
��Left=�$��340,336,0,0q�$��36��$��36��$	��Top=�$ 27���� -   $ Down5��$
��Left=�$��384,336,0,0q�$��36��$��36��$	��Top=�$ 28���� -   $ Down6��$
��Left=�$��428,336,0,0q�$��36��$��36��$	��Top=�$ 29���� -    $ Down7��$
��Left=�$��471,336,0,0q�$��36��$��36��$	��Top=�$ 30���� -!   $ Down8��$
��Left=�$��211,382,0,0q�$��36��$��36��$	��Top=�$ 31���� -"   $ Down9��$
��Left=�$��254,382,0,0q�$��36��$��36��$	��Top=�$ 32���� -#   $ Down10��$
��Left=�$��297,382,0,0q�$��36��$��36��$	��Top=�$ 33���� -$   $ Down11��$
��Left=�$��340,382,0,0q�$��36��$��36��$	��Top=�$ 34���� -%   $ Down12��$
��Left=�$��384,382,0,0q�$��36��$��36��$	��Top=�$ 35���� -&   $ Down13��$
��Left=�$��428,382,0,0q�$��36��$��36��$	��Top=�$ 36���� -'   $ Down14��$
��Left=�$��471,382,0,0q�$��36��$��36��$	��Top=�$ 37��