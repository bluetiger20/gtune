   M S B A M L   `   `   `  ����`  \RibbonControlsLibrary, Version=3.5.31016.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35tNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary!Microsoft.Windows.Controls.Ribbon  5      P LDockingLibrary, Version=0.1.5554.39456, Culture=neutral, PublicKeyToken=nullG4clr-namespace:DockingLibrary;assembly=DockingLibraryDockingLibrary 5   	   C ?Animator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5(clr-namespace:Animator;assembly=AnimatorAnimator 5   	    RibbonInkCanvas   gtune.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   \rNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary     5      Gcustom4clr-namespace:DockingLibrary;assembly=DockingLibrary     5   	   =animator(clr-namespace:Animator;assembly=Animator     5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $	��900��6)    � 	Resources 5	      5   /Microsoft.Windows.Controls.Ribbon.RibbonCommand   SaveCommand   
LabelTitle   LabelDescription   ToolTipTitle   ToolTipDescription   SmallImageSource   LargeImageSource  
NewCommand  Save_as_projectCommand  Save_as_singlefiletCommand  close_projectCommand  Open_Command  ApplicatioMenuCommand  EraserCommand  BrushCommand 	 RedColorCommand 
 BlueColorCommand  GreenColorCommand  TwitterCommand  FacebookCommand  CircleShapeCommand  StarShapeCommand  ToolsGroupCommand  BrushGroupCommand  ColorGroupCommand  SNSGroupCommandK   EMicrosoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinitionCollection  RibbonLayoutA   ;Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinition   ControlSizeDefinitionsC   =Microsoft.Windows.Controls.Ribbon.RibbonControlSizeDefinition	   	ImageSize
   IsLabelVisible   IsCollapsed��%d  &	        &	     &	     &	 <    &	 u    &	 �    &	 �    &	 �    &	 �    &		 �	    &	
 �
    &	     &	     &	 3    &	 N    &	 U    &	 W    &	 �    &	     &	 b    &	 �      5
   
   -   5        $ 저장��5      $* $변경된 내용을 저장합니다.��5      $ 변경된 내용 저장��5      $* $변경된 내용을 저장합니다.��5      $ Images\save.png��5      $ Images\save.png��5      5        5   
   -   5        $ 새로만들기��5      $- '새로운 프로젝트 시작합니다.��5      $ 새로만들기��5      $- '새로운 그리기를 시작합니다.��5      $ Images\New_Doc.png��5      $ Images\New_Doc.png��5      5        5   
   -   5        $ 프로젝트 저장��5      $&  프로젝트를 저장합니다.��5      $ 프로젝트 저장��5       $&  프로젝트를 저장합니다.��5!      $  Images\save_as_project.png��5"      $  Images\save_as_project.png��5#      5%        5'   
   -   5        $ 단일 파일 저장��5(      $. (단일 파일 저장을 저장합니다.��5)      $ 단일 파일 저장��5*      $. (단일 파일 저장울 저장합니다.��5+      $$ Images\savs_as_single_file.png��5,      $$ Images\savs_as_single_file.png��5-      5/        51   
   -   5        $ 프로젝트 종료��52      $&  프로젝트를 종료합니다.��53      $ 프로젝트 종료��54      $&  프로젝트를 종료합니다.��55      $ Images\close_project.png��56      $ Images\close_project.png��57      59        5<   
   -   5        $ 열기��5=      $$ 기존 프로젝트 엽니다.��5>      $ 프로젝트 열기��5?      $$ 기존 프로젝트 엽니다.��5@      $ Images\folder.png��5A      $ Images\folder.png��5B      5D        5E   
   $ Application Button��5F      $ Application Button.��5G      $ Images\Start_Menu.png��5H      $ Images\Start_Menu.png��5I      $ Ribbon Ink Canvas��5J      $/ )Click here to open Ribbon IncCanvas Menu.��5K        5M   
   -   5        $ 	지우개��5N      $> 8지우개를 선택하여 선을 지울수 있습니다.��5O      $ Images\eraser.png��5P      $ Images\eraser.png��5Q      $ 	지우개��5R      $> 8지우개를 선택하여 선을 지울수 있습니다.��5S      5U        5W   
   -	   5        $ New Document��5X      $A ;선그리기를 선택하여 선을 그릴수 있습니다.��5Y      $ Images\New_Doc.png��5Z      $ Images\New_Doc.png��5[      $ New Document��5\      $A ;선그리기를 선택하여 선을 그릴수 있습니다.��5]      5_        5a   
   -
   5        $ 	빨강색��5b      $0 *빨강색 선그리기를 선택합니다.��5c      $ Images\ball_red.png��5d      $ Images\ball_red.png��5e      $ 	지우개��5f      $0 *빨강색 선그리기를 선택합니다.��5g      5i        5k   
   -   5        $ 	파랑색��5l      $0 *파랑색 선그리기를 선택합니다.��5m      $ Images\ball_blue.png��5n      $ Images\ball_blue.png��5o      $ 	파랑색��5p      $0 *파랑색 선그리기를 선택합니다.��5q      5s        5u   
   -   5        $ 녹색��5v      $- '녹색 선그리기를 선택합니다.��5w      $ Images\ball_green.png��5x      $ Images\ball_green.png��5y      $ 녹색��5z      $- '녹색 선그리기를 선택합니다.��5{      5}        5   
   -   5        $ Twitter 공유��5�      $5 /그림을 Twitter 공유으로 공유합니다.��5�      $ Images\twitter.png��5�      $ Images\twitter.png��5�      $ Twitter 공유��5�      $5 /그림을 Twitter 공유으로 공유합니다.��5�      5�        5�   
   -   5        $ Facebook 공유��5�      $/ )그림을 Facebook으로 공유합니다.��5�      $ Images\facebook.png��5�      $ Images\facebook.png��5�      $ Facebook 공유��5�      $/ )그림을 Facebook으로 공유합니다.��5�      5�        5�   
   -   5        $ 	원모양��5�      $- '원모양으로 그림을 그립니다.��5�      $ Images\circle.png��5�      $ Images\circle.png��5�      $ 	원모양��5�      $- '원모양으로 그림을 그립니다.��5�      5�        5�   
   -   5        $ 	별모양��5�      $- '별모양으로 그림을 그립니다.��5�      $ Images\star.png��5�      $ Images\star.png��5�      $ 	별모양��5�      $, &별모양으로 그림을 그립니다��5�      5�        5�   
   $ 도구��64   $ Images\Transfer.png��6D   $ Images\Transfer.png��6k     5�   
   $ 모양��64   $ Images\brush.png��6D   $ Images\brush.png��6h     5�   
   $	 색��64   $ Images\color.png��6C   $ Images\color.png��6g     5�   
   $	 SNS��62   $ Images\twitter.png��6C   $ Images\twitter.png��6i     5�   
     5�      . 5�        $	 Large=�60   
 . 6B     5�      $	 Large=�60   
 . 6B     5�      $	 Large=�60   
 . 6B   5�        5�      . 5�        $	 Large=�60   
 . 6B     5�      $	 Small=�60   
 . 6B     5�      $	 Small=�60   
 . 6B   5�        5�      . 5�        $	 Large=�60   
 . 6B     5�      $	 Small=�60   
 . 6B   5�        5�       . 6*   5�      5�      .��5�      � -   5         �Name$ mainGrid��5�       � RowDefinitions 5�   
   �� 5�      $	��135 �6   �� 5�      .+�5�   
   �� $��0��6    �� Orientation$ Vertical=�6#   .+�5�      .   (Microsoft.Windows.Controls.Ribbon.Ribbon  $	��Top=�6      ApplicationMenu 5�      =   7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  5�         Command# [ 6.   .@�5�      A   ;Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem   m� Command# [ 66     5�      # [ 66     5�      # [  66     5�      # [ 66     5�      # [ 66     5�      # [ 66   5�         QuickAccessToolBar 5�      @   :Microsoft.Windows.Controls.Ribbon.RibbonQuickAccessToolBar  5�      .@�5�      4	   .Microsoft.Windows.Controls.Ribbon.RibbonButton	  #��[ 6)      	Placement$ InCustomizeMenu=�5�   1   	  5�      #��[  6)   $ InCustomizeMenuAndToolBar=�5�   1   5�         Tabs. 5�      1
   +Microsoft.Windows.Controls.Ribbon.RibbonTab
   
  Label$ 파일��6    
  Groups. 5�      3   -Microsoft.Windows.Controls.Ribbon.RibbonGroup     Command# [ 6$      GroupSizeDefinitions# [ 6Q      Controls. 5�      	  -   5        #��[ 5�   )   6Q   	  5�      #��[ 6)   5�        5�      # [ 6$   # [ 6Q   . 5�      	  #��[ 6)   	  5�      #��[ 6)   5�        5�      # [ 6$   # [ 6Q   . 5�      	  -   5        #��[	 5�   )   6T   	  5�      #��[
 6)   	  5�      #��[ 6)   5�      5�      
  5�      $ 편집��6   . 5�        # [ 6%   . 5�      	  #��[ 6)   	  5�      #��[ 6)   5�      5�      
  5�      $ 	리소스��6   5      
  5     $ 스크립트��6   5     
  5     $ 실행��6   5     
  5     $ 	윈도우��6   5     5     5     � 5
  
   $��1��6   ���#f5f5f5$��2,0,0,0q�63   .+�5        DockingLibrary.DockManager  -   5        $��dockManager��5  %   $
��Auto��69   ���#f5f5f56G   5/     51     52     