   M S B A M L   `   `   `  ���� K  GSAR Overlay Duel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SAR_Overlay_DuelSAR_Overlay_Duel  %    SAR_Overlay_Duel.Lobby_0_Window   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:SAR_Overlay_Duel       � Title$  Lobby_0_Window��$	��430��$	��680�� � Topmost .  � WindowStyle$
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
StartPoint$ 1.0,0&�.���  � Offset$ 0Q�� $	 0.7Q� � Color$ 	#7FFFFFFF��� $ 	#BFACD2EC��$ 1Q�.��� -   .+��� $��Resources/lobby0.jpg���� -    ��Name$
 Top1��$
��Left=�$��
300,56,0,0q�$	��Top=�$��36��$��36��
 � Tag$ 0���� -   $
 Top2��$
��Left=�$��
344,56,0,0q�$	��Top=�$��36��$��36��$ 1���� -   $
 Top3��$
��Left=�$��
300,97,0,0q�$	��Top=�$��36��$��36��$ 2���� -   $
 Top4��$
��Left=�$��
344,97,0,0q�$	��Top=�$��36��$��36��$ 3���� -   $
 Top5��$
��Left=�$��280,138,0,0q�$	��Top=�$��36��$��36��$ 4���� -   $
 Top6��$��Center=�$��	0,138,0,0q�$	��Top=�$��36��$��36��$ 5���� -   $
 Top7��$
��Left=�$��363,138,0,0q�$	��Top=�$��36��$��36��$ 6���� -	   $ Down1��$
��Left=�$��280,257,0,0q�$	��Top=�$��36��$��36��$ 7���� -
   $ Down2��$��Center=�$��	0,257,0,0q�$	��Top=�$��36��$��36��$ 8���� -   $ Down3��$
��Left=�$��363,257,0,0q�$	��Top=�$��36��$��36��$ 9���� -   $ Down4��$
��Left=�$��304,298,0,0q�$	��Top=�$��36��$��36��$ 10���� -   $ Down5��$
��Left=�$��345,298,0,0q�$	��Top=�$��36��$��36��$ 11���� -   $ Down6��$
��Left=�$��304,339,0,0q�$	��Top=�$��36��$��36��$ 12���� -   $ Down7��$
��Left=�$��345,339,0,0q�$	��Top=�$��36��$��36��$ 13���� -   $ Left1��$
��Left=�$��230,170,0,0q�$	��Top=�$��36��$��36��$ 14���� -   $ Left2��$
��Left=�$��188,170,0,0q�$	��Top=�$��36��$��36��$ 15���� -   $ Left3��$
��Left=�$��135,170,0,0q�$	��Top=�$��36��$��36��$ 16���� -   $ Left4��$
��Left=�$��
93,170,0,0q�$	��Top=�$��36��$��36��$ 17���� -   $ Left5��$
��Left=�$��
41,170,0,0q�$	��Top=�$��36��$��36��$ 18���� -   $ Left6��$
��Left=�$��	0,170,0,0q�$	��Top=�$��36��$��36��$ 19���� -   $ Left7��$
��Left=�$��230,229,0,0q�$	��Top=�$��36��$��36��$ 20���� -   $ Left8��$
��Left=�$��188,229,0,0q�$	��Top=�$��36��$��36��$ 21���� -   $ Left9��$
��Left=�$��135,229,0,0q�$	��Top=�$��36��$��36��$ 22���� -   $ Left10��$
��Left=�$��
93,229,0,0q�$	��Top=�$��36��$��36��$ 23���� -   $ Left11��$
��Left=�$��
41,229,0,0q�$	��Top=�$��36��$��36��$ 24���� -   $ Left12��$
��Left=�$��	0,229,0,0q�$	��Top=�$��36��$��36��$ 25���� -   $ Right1��$��Right=�$��0,170,229,0q�$	��Top=�$��36��$��36��$ 26���� -   $ Right2��$��Right=�$��0,170,186,0q�$	��Top=�$��36��$��36��$ 27���� -   $ Right3��$��Right=�$��0,170,135,0q�$	��Top=�$��36��$��36��$ 28���� -   $ Right4��$��Right=�$��
0,170,91,0q�$	��Top=�$��36��$��36��$ 29���� -    $ Right5��$��Right=�$��
0,170,41,0q�$	��Top=�$��36��$��36��$ 30���� -!   $ Right6��$��Right=�$��	0,170,0,0q�$	��Top=�$��36��$��36��$ 31���� -"   $ Right7��$��Right=�$��0,229,229,0q�$	��Top=�$��36��$��36��$ 32���� -#   $ Right8��$��Right=�$��0,229,186,0q�$	��Top=�$��36��$��36��$ 33���� -$   $ Right9��$��Right=�$��0,229,135,0q�$	��Top=�$��36��$��36��$ 34���� -%   $ Right10��$��Right=�$��
0,229,91,0q�$	��Top=�$��36��$��36��$ 35���� -&   $ Right11��$��Right=�$��
0,229,41,0q�$	��Top=�$��36��$��36��$ 36���� -'   $ Right12��$��Right=�$��	0,229,0,0q�$	��Top=�$��36��$��36��$ 37��