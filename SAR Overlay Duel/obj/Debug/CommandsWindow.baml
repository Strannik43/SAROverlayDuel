   M S B A M L   `   `   `  ����K  GSAR Overlay Duel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SAR_Overlay_DuelSAR_Overlay_Duel  5   	   %    SAR_Overlay_Duel.CommandsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:SAR_Overlay_Duel     5   	     � Title$  CommandsWindow��5   	   $	��480��6    $	��384��6-    � Topmost .  � WindowStyle$
 None=�6H    � 
ResizeMode$ NoResize=�6[    � AllowsTransparency .  J� Opacity$ 1Q�6�    � 	Resources 5	         FocusVisual �� Property �� Value	 �� StrokeDashArray
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
0 Shells 1 SpecialtyAmmo 2 SuperiteCartridges�� 5
   
   %s  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    '�� �    7   7  7  7  7  7  7  7 	 &	
 �   &	 &   &	 ^   &	 �   &	 �   &	    &	 D   &	 y   &	 �   &	 �   &	 	   &	 K	   &	 �	   &	 �	   &	 �	   &	 %
   &	 Z
   &	 �
   &	 �
   &	 �
   &	 #   &	 S   &	  �   &	! �   &	" �   &	# 0   &	$ l   &	% �   &	& �   &	'    &	( 2   &	) c   &	* �   &	+ �   &	, �    &	-    &	. :   &	/ n   &	0 �   &	1 �   &	2    �� 5      .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6(   $		 1 2R�63   #��� ��6I   
 . $��1��6�   5      5      5      �� 5      $ 	#FFDDDDDD��6?   �� 5      $ 	#FF707070��6;   �� 5      $ 	#FFBEE6FD��6B   �� 5      $ 	#FF3C7FB1��6>   �� 5      $ 	#FFC4E5F6��6@   �� 5      $ 	#FF2C628B��6<   �� 5      $ 	#FFF4F4F4��6A   �� 5      $ 	#FFADB2B5��6=   �� 5      $ 	#FF838383��6A   �� 5      " ��6   .�5      ��  �@�FocusVisualStyle8   65   �� 5        � �� �	#FF4747476/   �� 5"       � ��
 �����60   �� 5$       � ��
 �����6/   �� 5%       � ��$ 3q�64   �� 5&       � ��$
 Bold"�6/   �� 5'       � ��$ Center=�6?   �� 5(       � ��$ Center=�6=   �� 5)       � ��$ 1q�6,   �� 5*       � �� 5+      �� 5,      " ��6*   .R�5-      �� $ border��6%   $ 8��65   #��z��6F   #��z��6p   #��z��6�   
 . ._�5.   "   �� $ contentPresenter��63   |�.  #��z��6_   #��z��6�   ��. #
 z
 6�   #��z��6  5/       50      P� 51   "    �@��IsDefaulted . . �52   &   �� $ border��6D   # � ��6X    � ��53   #   P� 54   "    �@J�IsMouseOver . . �55   &   �� $ border��6C   8   � ��6W   �� 56   &   $ border��6D   8   � ��6X   57   #   P� 58   "    � �� . . �59   &   �� $ border��6C   8   � ��6W   �� 5:   &   $ border��6D   8   � ��6X   5;   #   P� 5<   "    � {� .  . �5=   &   �� $ border��6C   8   � ��6W   �� 5>   &   $ border��6D   8   � ��6X   �� 5?   &   $ contentPresenter��6O   8   � ��6m   5@   #   5B      5D      5E      �� 5F      $#��Resources/gun_pistol_grey.png��64   �� 5G      $$��Resources/gun_dualies_grey.png��69   �� 5H      $#��Resources/gun_magnum_grey.png��64   �� 5I      $#��Resources/gun_deagle_grey.png��64   �� 5J      $,��&Resources/gun_silenced_pistol_grey.png��6<   �� 5K      $$��Resources/gun_shotgun_grey.png��65   �� 5L      $!��Resources/gun_jag7_main.png��62   �� 5M      $ ��Resources/gun_smg_grey.png��61   �� 5N      $#��Resources/gun_thomas_grey.png��67   �� 5O      $��Resources/gun_ak_grey.png��61   �� 5P      $ ��Resources/gun_m16_grey.png��61   �� 5Q      $!��Resources/gun_dart_grey.png��6;   �� 5R      $$��Resources/gun_dartfly_grey.png��65   �� 5S      $"��Resources/gun_rifle_grey.png��6:   �� 5T      $#��Resources/gun_sniper_grey.png��64   �� 5U      $!��Resources/SuperiteLaser.png��6;   �� 5V      $$��Resources/gun_minigun_grey.png��65   �� 5W      $#��Resources/gun_bow_default.png��61   �� 5X      $��Resources/sparrow.png��6=   �� 5Y      $��Resources/bcg.png��62   �� 5[      $��Resources/cupgrade.png��66   �� 5\      $ ��Resources/bananaforker.png��6:   �� 5]      $$��Resources/attach-bandolier.png��6<   �� 5^      $$��Resources/attach-clawshoes.png��67   �� 5_      $%��Resources/attach-ninjashoes.png��6:   �� 5`      $(��"Resources/attach-tapedispenser.png��6;   �� 5a      $ ��Resources/skunkshorkel.png��6=   �� 5b      $��Resources/SuperJuicer.png��69   �� 5d      $��Resources/banana.png��64   �� 5f      $��Resources/armor1lvl.png��64   �� 5g      $��Resources/armor2lvl.png��64   �� 5h      $��Resources/armor3lvl.png��64   �� 5j      $��Resources/juice.png��63   �� 5k      $��Resources/SuperTape.png��62   �� 5l      6   �� 5m      $!��Resources/ammo_pistolUI.png��6;   �� 5n      $ ��Resources/ammo_rifleUI.png��68   �� 5o      $!��Resources/ammo_sniperUI.png��6;   �� 5p      $"��Resources/ammo_shotgunUI.png��64   �� 5q      $$��Resources/ammo_specialtyUI.png��6;   �� 5r      $&�� Resources/SuperiteCartridges.png��6@   5s      ��5v      �� 5w   
    �� EndPoint$ 0.0,0&�6    �� 
StartPoint$ 1.0,0&�6/   .��5x      �  � Offset$ 0Q�6   � 5y      $	 0.7Q�6    � Color$ 	#7FFFFFFF��6(   � 5z      $ 	#BFACD2EC��6   $ 1Q�6-   5{      .��5}      � -   5         � ColumnDefinitions 5~   
   �� 5      �� 5�      �� 5�      �� 5�      �� 5�       � RowDefinitions 5�   
   �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      .+�5�   
   �� $��MatchID��6   $��0��6#   $��0��63   
 � Tag$ matchid��6@   �� 5�   
   $��Gasoff��6   $��1��6"   $��0��62   $ gasoff��6?   �� 5�   
   $��Night��6   $��4��6!   $��3��61   $ night��6>   �� 5�   
   $��
Getplayers��6   $��3��6&   $��0��66   $ 
getplayers��6C   �� 5�   
   $��Gasstart��6   $��1��6$   $��1��64   $ gasstart��6A   �� 5�   
   $��Onehits��6   $��0��6#   $��1��63   $ onehits��6@   �� 5�   
   $��Noroll��6   $��3��6"   $��3��62   $ noroll��6?   �� 5�   
   $
��Rain��6   $��2��6    $��1��60   $
 rain��6=   �� 5�   
   $
��Pets��6   $��3��6    $��1��60   $
 pets��6=   �� 5�   
   $��Moles��6   $��4��6!   $��1��61   $ moles��6>   �� 5�   
   $��Armors��6   $��0��6"   $��2��62   $ onehits��6?   �� 5�   
   $��
Throwables��6   $��1��6&   $��2��66   $ 
throwables��6C   �� 5�   
   $
��Guns��6   $��2��6    $��2��60   $
 guns��6=   �� 5�   
   $��Allitems��6   $��3��6$   $��2��64   $ allitems��6A   �� 5�   
   $��Moles��6   $��4��6!   $��2��61   $ moles��6>   �� 5�   
   $��Utils��6   $��0��6!   $��3��61   $ utils��6>   �� 5�   
   $
��Emus��6   $��1��6    $��3��60   $
 emus��6=   �� 5�   
   $��Allitems��6   $��4��6$   $��0��64   $ allitems��6A   �� 5�   
   $��Startp��6   $��2��6"   $��0��62   $ startp��6?   �� 5�   
   $��God All��6   $��2��6#   $��3��63   $ god all��6@   5�      5�      