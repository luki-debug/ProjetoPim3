	.arch	armv7-a
	.syntax unified
	.eabi_attribute 67, "2.09"	@ Tag_conformance
	.eabi_attribute 6, 10	@ Tag_CPU_arch
	.eabi_attribute 7, 65	@ Tag_CPU_arch_profile
	.eabi_attribute 8, 1	@ Tag_ARM_ISA_use
	.eabi_attribute 9, 2	@ Tag_THUMB_ISA_use
	.fpu	vfpv3-d16
	.eabi_attribute 34, 1	@ Tag_CPU_unaligned_access
	.eabi_attribute 15, 1	@ Tag_ABI_PCS_RW_data
	.eabi_attribute 16, 1	@ Tag_ABI_PCS_RO_data
	.eabi_attribute 17, 2	@ Tag_ABI_PCS_GOT_use
	.eabi_attribute 20, 2	@ Tag_ABI_FP_denormal
	.eabi_attribute 21, 0	@ Tag_ABI_FP_exceptions
	.eabi_attribute 23, 3	@ Tag_ABI_FP_number_model
	.eabi_attribute 24, 1	@ Tag_ABI_align_needed
	.eabi_attribute 25, 1	@ Tag_ABI_align_preserved
	.eabi_attribute 38, 1	@ Tag_ABI_FP_16bit_format
	.eabi_attribute 18, 4	@ Tag_ABI_PCS_wchar_t
	.eabi_attribute 26, 2	@ Tag_ABI_enum_size
	.eabi_attribute 14, 0	@ Tag_ABI_PCS_R9_use
	.file	"typemaps.armeabi-v7a.s"

/* map_module_count: START */
	.section	.rodata.map_module_count,"a",%progbits
	.type	map_module_count, %object
	.p2align	2
	.global	map_module_count
map_module_count:
	.size	map_module_count, 4
	.long	13
/* map_module_count: END */

/* java_type_count: START */
	.section	.rodata.java_type_count,"a",%progbits
	.type	java_type_count, %object
	.p2align	2
	.global	java_type_count
java_type_count:
	.size	java_type_count, 4
	.long	317
/* java_type_count: END */

/* java_name_width: START */
	.section	.rodata.java_name_width,"a",%progbits
	.type	java_name_width, %object
	.p2align	2
	.global	java_name_width
java_name_width:
	.size	java_name_width, 4
	.long	85
/* java_name_width: END */

	.include	"typemaps.armeabi-v7a-shared.inc"
	.include	"typemaps.armeabi-v7a-managed.inc"

/* Managed to Java map: START */
	.section	.data.rel.map_modules,"aw",%progbits
	.type	map_modules, %object
	.p2align	2
	.global	map_modules
map_modules:
	/* module_uuid: 9e1c2902-3feb-485b-b08e-f3a5d06fb7c4 */
	.byte	0x02, 0x29, 0x1c, 0x9e, 0xeb, 0x3f, 0x5b, 0x48, 0xb0, 0x8e, 0xf3, 0xa5, 0xd0, 0x6f, 0xb7, 0xc4
	/* entry_count */
	.long	214
	/* duplicate_count */
	.long	39
	/* map */
	.long	module0_managed_to_java
	/* duplicate_map */
	.long	module0_managed_to_java_duplicates
	/* assembly_name: Mono.Android */
	.long	.L.map_aname.0
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 09141c10-1205-448b-a0de-71c21fda627a */
	.byte	0x10, 0x1c, 0x14, 0x09, 0x05, 0x12, 0x8b, 0x44, 0xa0, 0xde, 0x71, 0xc2, 0x1f, 0xda, 0x62, 0x7a
	/* entry_count */
	.long	26
	/* duplicate_count */
	.long	2
	/* map */
	.long	module1_managed_to_java
	/* duplicate_map */
	.long	module1_managed_to_java_duplicates
	/* assembly_name: Xamarin.Android.Support.Compat */
	.long	.L.map_aname.1
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 5b459123-67cc-484d-8df8-7210de5e32a8 */
	.byte	0x23, 0x91, 0x45, 0x5b, 0xcc, 0x67, 0x4d, 0x48, 0x8d, 0xf8, 0x72, 0x10, 0xde, 0x5e, 0x32, 0xa8
	/* entry_count */
	.long	9
	/* duplicate_count */
	.long	3
	/* map */
	.long	module2_managed_to_java
	/* duplicate_map */
	.long	module2_managed_to_java_duplicates
	/* assembly_name: Xamarin.Android.Support.Fragment */
	.long	.L.map_aname.2
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 0d469737-7cab-4b5d-9e93-be53a4f30d70 */
	.byte	0x37, 0x97, 0x46, 0x0d, 0xab, 0x7c, 0x5d, 0x4b, 0x9e, 0x93, 0xbe, 0x53, 0xa4, 0xf3, 0x0d, 0x70
	/* entry_count */
	.long	3
	/* duplicate_count */
	.long	0
	/* map */
	.long	module3_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Xamarin.Android.Support.DrawerLayout */
	.long	.L.map_aname.3
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: b8133439-8cc7-4079-a9a3-fd61f42c670b */
	.byte	0x39, 0x34, 0x13, 0xb8, 0xc7, 0x8c, 0x79, 0x40, 0xa9, 0xa3, 0xfd, 0x61, 0xf4, 0x2c, 0x67, 0x0b
	/* entry_count */
	.long	5
	/* duplicate_count */
	.long	1
	/* map */
	.long	module4_managed_to_java
	/* duplicate_map */
	.long	module4_managed_to_java_duplicates
	/* assembly_name: Xamarin.Android.Support.Loader */
	.long	.L.map_aname.4
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: d0906070-920c-4ebd-a390-173ac972b67c */
	.byte	0x70, 0x60, 0x90, 0xd0, 0x0c, 0x92, 0xbd, 0x4e, 0xa3, 0x90, 0x17, 0x3a, 0xc9, 0x72, 0xb6, 0x7c
	/* entry_count */
	.long	2
	/* duplicate_count */
	.long	1
	/* map */
	.long	module5_managed_to_java
	/* duplicate_map */
	.long	module5_managed_to_java_duplicates
	/* assembly_name: Xamarin.Android.Arch.Lifecycle.LiveData.Core */
	.long	.L.map_aname.5
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 3983c281-06cd-4598-9a17-b3ef4a712e8e */
	.byte	0x81, 0xc2, 0x83, 0x39, 0xcd, 0x06, 0x98, 0x45, 0x9a, 0x17, 0xb3, 0xef, 0x4a, 0x71, 0x2e, 0x8e
	/* entry_count */
	.long	17
	/* duplicate_count */
	.long	3
	/* map */
	.long	module6_managed_to_java
	/* duplicate_map */
	.long	module6_managed_to_java_duplicates
	/* assembly_name: Xamarin.Android.Support.Design */
	.long	.L.map_aname.6
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 3a086b8d-3e19-416c-8c11-6dc2587d73a6 */
	.byte	0x8d, 0x6b, 0x08, 0x3a, 0x19, 0x3e, 0x6c, 0x41, 0x8c, 0x11, 0x6d, 0xc2, 0x58, 0x7d, 0x73, 0xa6
	/* entry_count */
	.long	3
	/* duplicate_count */
	.long	1
	/* map */
	.long	module7_managed_to_java
	/* duplicate_map */
	.long	module7_managed_to_java_duplicates
	/* assembly_name: Xamarin.Android.Support.CoordinaterLayout */
	.long	.L.map_aname.7
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: e72e94a8-8df9-49d3-b1ab-0ab743fc2949 */
	.byte	0xa8, 0x94, 0x2e, 0xe7, 0xf9, 0x8d, 0xd3, 0x49, 0xb1, 0xab, 0x0a, 0xb7, 0x43, 0xfc, 0x29, 0x49
	/* entry_count */
	.long	30
	/* duplicate_count */
	.long	4
	/* map */
	.long	module8_managed_to_java
	/* duplicate_map */
	.long	module8_managed_to_java_duplicates
	/* assembly_name: Xamarin.Android.Support.v7.AppCompat */
	.long	.L.map_aname.8
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 6ab406c2-7f04-4088-b058-2ed5df66c238 */
	.byte	0xc2, 0x06, 0xb4, 0x6a, 0x04, 0x7f, 0x88, 0x40, 0xb0, 0x58, 0x2e, 0xd5, 0xdf, 0x66, 0xc2, 0x38
	/* entry_count */
	.long	4
	/* duplicate_count */
	.long	1
	/* map */
	.long	module9_managed_to_java
	/* duplicate_map */
	.long	module9_managed_to_java_duplicates
	/* assembly_name: Xamarin.Android.Arch.Lifecycle.Common */
	.long	.L.map_aname.9
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 57bea0c6-85ce-4755-b7bf-07c82d72c287 */
	.byte	0xc6, 0xa0, 0xbe, 0x57, 0xce, 0x85, 0x55, 0x47, 0xb7, 0xbf, 0x07, 0xc8, 0x2d, 0x72, 0xc2, 0x87
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.long	module10_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: CamadaMobile */
	.long	.L.map_aname.10
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: e4048fd9-f99b-4e68-ab20-4fc1fb513337 */
	.byte	0xd9, 0x8f, 0x04, 0xe4, 0x9b, 0xf9, 0x68, 0x4e, 0xab, 0x20, 0x4f, 0xc1, 0xfb, 0x51, 0x33, 0x37
	/* entry_count */
	.long	2
	/* duplicate_count */
	.long	0
	/* map */
	.long	module11_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Xamarin.Android.Arch.Lifecycle.ViewModel */
	.long	.L.map_aname.11
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: a2afd7ed-e011-4880-a610-7072ae7d464c */
	.byte	0xed, 0xd7, 0xaf, 0xa2, 0x11, 0xe0, 0x80, 0x48, 0xa6, 0x10, 0x70, 0x72, 0xae, 0x7d, 0x46, 0x4c
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.long	module12_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Xamarin.Essentials */
	.long	.L.map_aname.12
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	.size	map_modules, 624
/* Managed to Java map: END */

/* Java to managed map: START */
	.section	.rodata.map_java,"a",%progbits
	.type	map_java, %object
	.p2align	2
	.global	map_java
map_java:
	/* #0 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554618
	/* java_name */
	.ascii	"android/animation/Animator"
	.zero	59

	/* #1 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554620
	/* java_name */
	.ascii	"android/animation/Animator$AnimatorListener"
	.zero	42

	/* #2 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554622
	/* java_name */
	.ascii	"android/animation/Animator$AnimatorPauseListener"
	.zero	37

	/* #3 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554624
	/* java_name */
	.ascii	"android/animation/AnimatorListenerAdapter"
	.zero	44

	/* #4 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554627
	/* java_name */
	.ascii	"android/animation/TimeInterpolator"
	.zero	51

	/* #5 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554629
	/* java_name */
	.ascii	"android/app/Activity"
	.zero	65

	/* #6 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554630
	/* java_name */
	.ascii	"android/app/Application"
	.zero	62

	/* #7 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554632
	/* java_name */
	.ascii	"android/app/Application$ActivityLifecycleCallbacks"
	.zero	35

	/* #8 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554633
	/* java_name */
	.ascii	"android/app/Dialog"
	.zero	67

	/* #9 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554637
	/* java_name */
	.ascii	"android/app/PendingIntent"
	.zero	60

	/* #10 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"android/arch/lifecycle/Lifecycle"
	.zero	53

	/* #11 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"android/arch/lifecycle/Lifecycle$State"
	.zero	47

	/* #12 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"android/arch/lifecycle/LifecycleObserver"
	.zero	45

	/* #13 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"android/arch/lifecycle/LifecycleOwner"
	.zero	48

	/* #14 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"android/arch/lifecycle/LiveData"
	.zero	54

	/* #15 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"android/arch/lifecycle/Observer"
	.zero	54

	/* #16 */
	/* module_index */
	.long	11
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"android/arch/lifecycle/ViewModelStore"
	.zero	48

	/* #17 */
	/* module_index */
	.long	11
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"android/arch/lifecycle/ViewModelStoreOwner"
	.zero	43

	/* #18 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554645
	/* java_name */
	.ascii	"android/content/ComponentCallbacks"
	.zero	51

	/* #19 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554647
	/* java_name */
	.ascii	"android/content/ComponentCallbacks2"
	.zero	50

	/* #20 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554640
	/* java_name */
	.ascii	"android/content/ComponentName"
	.zero	56

	/* #21 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554638
	/* java_name */
	.ascii	"android/content/Context"
	.zero	62

	/* #22 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554642
	/* java_name */
	.ascii	"android/content/ContextWrapper"
	.zero	55

	/* #23 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554649
	/* java_name */
	.ascii	"android/content/DialogInterface"
	.zero	54

	/* #24 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554639
	/* java_name */
	.ascii	"android/content/Intent"
	.zero	63

	/* #25 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554650
	/* java_name */
	.ascii	"android/content/IntentSender"
	.zero	57

	/* #26 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554656
	/* java_name */
	.ascii	"android/content/SharedPreferences"
	.zero	52

	/* #27 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554652
	/* java_name */
	.ascii	"android/content/SharedPreferences$Editor"
	.zero	45

	/* #28 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554654
	/* java_name */
	.ascii	"android/content/SharedPreferences$OnSharedPreferenceChangeListener"
	.zero	19

	/* #29 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554658
	/* java_name */
	.ascii	"android/content/pm/PackageInfo"
	.zero	55

	/* #30 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554660
	/* java_name */
	.ascii	"android/content/pm/PackageManager"
	.zero	52

	/* #31 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554663
	/* java_name */
	.ascii	"android/content/res/ColorStateList"
	.zero	51

	/* #32 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554664
	/* java_name */
	.ascii	"android/content/res/Configuration"
	.zero	52

	/* #33 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554665
	/* java_name */
	.ascii	"android/content/res/Resources"
	.zero	56

	/* #34 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554666
	/* java_name */
	.ascii	"android/content/res/TypedArray"
	.zero	55

	/* #35 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554487
	/* java_name */
	.ascii	"android/database/DataSetObserver"
	.zero	53

	/* #36 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554605
	/* java_name */
	.ascii	"android/graphics/Canvas"
	.zero	62

	/* #37 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554606
	/* java_name */
	.ascii	"android/graphics/ColorFilter"
	.zero	57

	/* #38 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554607
	/* java_name */
	.ascii	"android/graphics/Matrix"
	.zero	62

	/* #39 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554608
	/* java_name */
	.ascii	"android/graphics/Paint"
	.zero	63

	/* #40 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554609
	/* java_name */
	.ascii	"android/graphics/Point"
	.zero	63

	/* #41 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554610
	/* java_name */
	.ascii	"android/graphics/PorterDuff"
	.zero	58

	/* #42 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554611
	/* java_name */
	.ascii	"android/graphics/PorterDuff$Mode"
	.zero	53

	/* #43 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554612
	/* java_name */
	.ascii	"android/graphics/Rect"
	.zero	64

	/* #44 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554613
	/* java_name */
	.ascii	"android/graphics/RectF"
	.zero	63

	/* #45 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554614
	/* java_name */
	.ascii	"android/graphics/drawable/Drawable"
	.zero	51

	/* #46 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554616
	/* java_name */
	.ascii	"android/graphics/drawable/Drawable$Callback"
	.zero	42

	/* #47 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554602
	/* java_name */
	.ascii	"android/net/Uri"
	.zero	70

	/* #48 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554590
	/* java_name */
	.ascii	"android/os/BaseBundle"
	.zero	64

	/* #49 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554591
	/* java_name */
	.ascii	"android/os/Build"
	.zero	69

	/* #50 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554592
	/* java_name */
	.ascii	"android/os/Build$VERSION"
	.zero	61

	/* #51 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554594
	/* java_name */
	.ascii	"android/os/Bundle"
	.zero	68

	/* #52 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554589
	/* java_name */
	.ascii	"android/os/Handler"
	.zero	67

	/* #53 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554599
	/* java_name */
	.ascii	"android/os/Looper"
	.zero	68

	/* #54 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554600
	/* java_name */
	.ascii	"android/os/Parcel"
	.zero	68

	/* #55 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554598
	/* java_name */
	.ascii	"android/os/Parcelable"
	.zero	64

	/* #56 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554596
	/* java_name */
	.ascii	"android/os/Parcelable$Creator"
	.zero	56

	/* #57 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554588
	/* java_name */
	.ascii	"android/preference/PreferenceManager"
	.zero	49

	/* #58 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554712
	/* java_name */
	.ascii	"android/runtime/JavaProxyThrowable"
	.zero	51

	/* #59 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554441
	/* java_name */
	.ascii	"android/support/design/animation/MotionSpec"
	.zero	42

	/* #60 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"android/support/design/animation/MotionTiming"
	.zero	40

	/* #61 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"android/support/design/expandable/ExpandableTransformationWidget"
	.zero	21

	/* #62 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"android/support/design/expandable/ExpandableWidget"
	.zero	35

	/* #63 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"android/support/design/snackbar/ContentViewCallback"
	.zero	34

	/* #64 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554447
	/* java_name */
	.ascii	"android/support/design/widget/BaseTransientBottomBar"
	.zero	33

	/* #65 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554448
	/* java_name */
	.ascii	"android/support/design/widget/BaseTransientBottomBar$BaseCallback"
	.zero	20

	/* #66 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554450
	/* java_name */
	.ascii	"android/support/design/widget/BaseTransientBottomBar$Behavior"
	.zero	24

	/* #67 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"android/support/design/widget/CoordinatorLayout"
	.zero	38

	/* #68 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"android/support/design/widget/CoordinatorLayout$Behavior"
	.zero	29

	/* #69 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"android/support/design/widget/CoordinatorLayout$LayoutParams"
	.zero	25

	/* #70 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554452
	/* java_name */
	.ascii	"android/support/design/widget/FloatingActionButton"
	.zero	35

	/* #71 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554453
	/* java_name */
	.ascii	"android/support/design/widget/FloatingActionButton$OnVisibilityChangedListener"
	.zero	7

	/* #72 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554443
	/* java_name */
	.ascii	"android/support/design/widget/Snackbar"
	.zero	47

	/* #73 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554445
	/* java_name */
	.ascii	"android/support/design/widget/Snackbar$Callback"
	.zero	38

	/* #74 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"android/support/design/widget/Snackbar_SnackbarActionClickImplementor"
	.zero	16

	/* #75 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554455
	/* java_name */
	.ascii	"android/support/design/widget/SwipeDismissBehavior"
	.zero	35

	/* #76 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554457
	/* java_name */
	.ascii	"android/support/design/widget/SwipeDismissBehavior$OnDismissListener"
	.zero	17

	/* #77 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554446
	/* java_name */
	.ascii	"android/support/design/widget/VisibilityAwareImageButton"
	.zero	29

	/* #78 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"android/support/v13/view/DragAndDropPermissionsCompat"
	.zero	32

	/* #79 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554470
	/* java_name */
	.ascii	"android/support/v4/app/ActivityCompat"
	.zero	48

	/* #80 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554472
	/* java_name */
	.ascii	"android/support/v4/app/ActivityCompat$OnRequestPermissionsResultCallback"
	.zero	13

	/* #81 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554474
	/* java_name */
	.ascii	"android/support/v4/app/ActivityCompat$PermissionCompatDelegate"
	.zero	23

	/* #82 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554476
	/* java_name */
	.ascii	"android/support/v4/app/ActivityCompat$RequestPermissionsRequestCodeValidator"
	.zero	9

	/* #83 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"android/support/v4/app/Fragment"
	.zero	54

	/* #84 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"android/support/v4/app/Fragment$SavedState"
	.zero	43

	/* #85 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"android/support/v4/app/FragmentActivity"
	.zero	46

	/* #86 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"android/support/v4/app/FragmentManager"
	.zero	47

	/* #87 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"android/support/v4/app/FragmentManager$BackStackEntry"
	.zero	32

	/* #88 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554441
	/* java_name */
	.ascii	"android/support/v4/app/FragmentManager$FragmentLifecycleCallbacks"
	.zero	20

	/* #89 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"android/support/v4/app/FragmentManager$OnBackStackChangedListener"
	.zero	20

	/* #90 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554449
	/* java_name */
	.ascii	"android/support/v4/app/FragmentTransaction"
	.zero	43

	/* #91 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"android/support/v4/app/LoaderManager"
	.zero	49

	/* #92 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"android/support/v4/app/LoaderManager$LoaderCallbacks"
	.zero	33

	/* #93 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554477
	/* java_name */
	.ascii	"android/support/v4/app/SharedElementCallback"
	.zero	41

	/* #94 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554479
	/* java_name */
	.ascii	"android/support/v4/app/SharedElementCallback$OnSharedElementsReadyListener"
	.zero	11

	/* #95 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554481
	/* java_name */
	.ascii	"android/support/v4/app/TaskStackBuilder"
	.zero	46

	/* #96 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554483
	/* java_name */
	.ascii	"android/support/v4/app/TaskStackBuilder$SupportParentable"
	.zero	28

	/* #97 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554469
	/* java_name */
	.ascii	"android/support/v4/content/ContextCompat"
	.zero	45

	/* #98 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"android/support/v4/content/Loader"
	.zero	52

	/* #99 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"android/support/v4/content/Loader$OnLoadCanceledListener"
	.zero	29

	/* #100 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"android/support/v4/content/Loader$OnLoadCompleteListener"
	.zero	29

	/* #101 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554466
	/* java_name */
	.ascii	"android/support/v4/internal/view/SupportMenu"
	.zero	41

	/* #102 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554468
	/* java_name */
	.ascii	"android/support/v4/internal/view/SupportMenuItem"
	.zero	37

	/* #103 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"android/support/v4/view/ActionProvider"
	.zero	47

	/* #104 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"android/support/v4/view/ActionProvider$SubUiVisibilityListener"
	.zero	23

	/* #105 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"android/support/v4/view/ActionProvider$VisibilityListener"
	.zero	28

	/* #106 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554452
	/* java_name */
	.ascii	"android/support/v4/view/DisplayCutoutCompat"
	.zero	42

	/* #107 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554454
	/* java_name */
	.ascii	"android/support/v4/view/NestedScrollingParent"
	.zero	40

	/* #108 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554456
	/* java_name */
	.ascii	"android/support/v4/view/NestedScrollingParent2"
	.zero	39

	/* #109 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554458
	/* java_name */
	.ascii	"android/support/v4/view/TintableBackgroundView"
	.zero	39

	/* #110 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554463
	/* java_name */
	.ascii	"android/support/v4/view/ViewPropertyAnimatorCompat"
	.zero	35

	/* #111 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"android/support/v4/view/ViewPropertyAnimatorListener"
	.zero	33

	/* #112 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554462
	/* java_name */
	.ascii	"android/support/v4/view/ViewPropertyAnimatorUpdateListener"
	.zero	27

	/* #113 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554464
	/* java_name */
	.ascii	"android/support/v4/view/WindowInsetsCompat"
	.zero	43

	/* #114 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"android/support/v4/widget/DrawerLayout"
	.zero	47

	/* #115 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"android/support/v4/widget/DrawerLayout$DrawerListener"
	.zero	32

	/* #116 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"android/support/v4/widget/TintableImageSourceView"
	.zero	36

	/* #117 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"android/support/v7/app/ActionBar"
	.zero	53

	/* #118 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"android/support/v7/app/ActionBar$LayoutParams"
	.zero	40

	/* #119 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"android/support/v7/app/ActionBar$OnMenuVisibilityListener"
	.zero	28

	/* #120 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554443
	/* java_name */
	.ascii	"android/support/v7/app/ActionBar$OnNavigationListener"
	.zero	32

	/* #121 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"android/support/v7/app/ActionBar$Tab"
	.zero	49

	/* #122 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554447
	/* java_name */
	.ascii	"android/support/v7/app/ActionBar$TabListener"
	.zero	41

	/* #123 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554451
	/* java_name */
	.ascii	"android/support/v7/app/ActionBarDrawerToggle"
	.zero	41

	/* #124 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554453
	/* java_name */
	.ascii	"android/support/v7/app/ActionBarDrawerToggle$Delegate"
	.zero	32

	/* #125 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554455
	/* java_name */
	.ascii	"android/support/v7/app/ActionBarDrawerToggle$DelegateProvider"
	.zero	24

	/* #126 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554456
	/* java_name */
	.ascii	"android/support/v7/app/AppCompatActivity"
	.zero	45

	/* #127 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"android/support/v7/app/AppCompatCallback"
	.zero	45

	/* #128 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554457
	/* java_name */
	.ascii	"android/support/v7/app/AppCompatDelegate"
	.zero	45

	/* #129 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"android/support/v7/graphics/drawable/DrawerArrowDrawable"
	.zero	29

	/* #130 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554474
	/* java_name */
	.ascii	"android/support/v7/view/ActionMode"
	.zero	51

	/* #131 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554476
	/* java_name */
	.ascii	"android/support/v7/view/ActionMode$Callback"
	.zero	42

	/* #132 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554478
	/* java_name */
	.ascii	"android/support/v7/view/menu/MenuBuilder"
	.zero	45

	/* #133 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554480
	/* java_name */
	.ascii	"android/support/v7/view/menu/MenuBuilder$Callback"
	.zero	36

	/* #134 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554487
	/* java_name */
	.ascii	"android/support/v7/view/menu/MenuItemImpl"
	.zero	44

	/* #135 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554484
	/* java_name */
	.ascii	"android/support/v7/view/menu/MenuPresenter"
	.zero	43

	/* #136 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554482
	/* java_name */
	.ascii	"android/support/v7/view/menu/MenuPresenter$Callback"
	.zero	34

	/* #137 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554486
	/* java_name */
	.ascii	"android/support/v7/view/menu/MenuView"
	.zero	48

	/* #138 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554488
	/* java_name */
	.ascii	"android/support/v7/view/menu/SubMenuBuilder"
	.zero	42

	/* #139 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554471
	/* java_name */
	.ascii	"android/support/v7/widget/DecorToolbar"
	.zero	47

	/* #140 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554472
	/* java_name */
	.ascii	"android/support/v7/widget/ScrollingTabContainerView"
	.zero	34

	/* #141 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554473
	/* java_name */
	.ascii	"android/support/v7/widget/ScrollingTabContainerView$VisibilityAnimListener"
	.zero	11

	/* #142 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554461
	/* java_name */
	.ascii	"android/support/v7/widget/Toolbar"
	.zero	52

	/* #143 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554465
	/* java_name */
	.ascii	"android/support/v7/widget/Toolbar$OnMenuItemClickListener"
	.zero	28

	/* #144 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554462
	/* java_name */
	.ascii	"android/support/v7/widget/Toolbar_NavigationOnClickEventDispatcher"
	.zero	19

	/* #145 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554586
	/* java_name */
	.ascii	"android/util/AttributeSet"
	.zero	60

	/* #146 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554584
	/* java_name */
	.ascii	"android/util/DisplayMetrics"
	.zero	58

	/* #147 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554587
	/* java_name */
	.ascii	"android/util/SparseArray"
	.zero	61

	/* #148 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554521
	/* java_name */
	.ascii	"android/view/ActionMode"
	.zero	62

	/* #149 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554523
	/* java_name */
	.ascii	"android/view/ActionMode$Callback"
	.zero	53

	/* #150 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554526
	/* java_name */
	.ascii	"android/view/ActionProvider"
	.zero	58

	/* #151 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554535
	/* java_name */
	.ascii	"android/view/ContextMenu"
	.zero	61

	/* #152 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554533
	/* java_name */
	.ascii	"android/view/ContextMenu$ContextMenuInfo"
	.zero	45

	/* #153 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554528
	/* java_name */
	.ascii	"android/view/ContextThemeWrapper"
	.zero	53

	/* #154 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554529
	/* java_name */
	.ascii	"android/view/Display"
	.zero	65

	/* #155 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554530
	/* java_name */
	.ascii	"android/view/DragEvent"
	.zero	63

	/* #156 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554544
	/* java_name */
	.ascii	"android/view/InputEvent"
	.zero	62

	/* #157 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554509
	/* java_name */
	.ascii	"android/view/KeyEvent"
	.zero	64

	/* #158 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554511
	/* java_name */
	.ascii	"android/view/KeyEvent$Callback"
	.zero	55

	/* #159 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554512
	/* java_name */
	.ascii	"android/view/LayoutInflater"
	.zero	58

	/* #160 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554514
	/* java_name */
	.ascii	"android/view/LayoutInflater$Factory"
	.zero	50

	/* #161 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554516
	/* java_name */
	.ascii	"android/view/LayoutInflater$Factory2"
	.zero	49

	/* #162 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554537
	/* java_name */
	.ascii	"android/view/Menu"
	.zero	68

	/* #163 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554559
	/* java_name */
	.ascii	"android/view/MenuInflater"
	.zero	60

	/* #164 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554543
	/* java_name */
	.ascii	"android/view/MenuItem"
	.zero	64

	/* #165 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554539
	/* java_name */
	.ascii	"android/view/MenuItem$OnActionExpandListener"
	.zero	41

	/* #166 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554541
	/* java_name */
	.ascii	"android/view/MenuItem$OnMenuItemClickListener"
	.zero	40

	/* #167 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554517
	/* java_name */
	.ascii	"android/view/MotionEvent"
	.zero	61

	/* #168 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554562
	/* java_name */
	.ascii	"android/view/SearchEvent"
	.zero	61

	/* #169 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554547
	/* java_name */
	.ascii	"android/view/SubMenu"
	.zero	65

	/* #170 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554501
	/* java_name */
	.ascii	"android/view/View"
	.zero	68

	/* #171 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554503
	/* java_name */
	.ascii	"android/view/View$OnClickListener"
	.zero	52

	/* #172 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554506
	/* java_name */
	.ascii	"android/view/View$OnCreateContextMenuListener"
	.zero	40

	/* #173 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554566
	/* java_name */
	.ascii	"android/view/ViewGroup"
	.zero	63

	/* #174 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554567
	/* java_name */
	.ascii	"android/view/ViewGroup$LayoutParams"
	.zero	50

	/* #175 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554568
	/* java_name */
	.ascii	"android/view/ViewGroup$MarginLayoutParams"
	.zero	44

	/* #176 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554549
	/* java_name */
	.ascii	"android/view/ViewManager"
	.zero	61

	/* #177 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554551
	/* java_name */
	.ascii	"android/view/ViewParent"
	.zero	62

	/* #178 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554570
	/* java_name */
	.ascii	"android/view/ViewPropertyAnimator"
	.zero	52

	/* #179 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554518
	/* java_name */
	.ascii	"android/view/Window"
	.zero	66

	/* #180 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554520
	/* java_name */
	.ascii	"android/view/Window$Callback"
	.zero	57

	/* #181 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554554
	/* java_name */
	.ascii	"android/view/WindowManager"
	.zero	59

	/* #182 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554552
	/* java_name */
	.ascii	"android/view/WindowManager$LayoutParams"
	.zero	46

	/* #183 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554577
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityEvent"
	.zero	40

	/* #184 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554583
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityEventSource"
	.zero	34

	/* #185 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554578
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityRecord"
	.zero	39

	/* #186 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554573
	/* java_name */
	.ascii	"android/view/animation/Animation"
	.zero	53

	/* #187 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554576
	/* java_name */
	.ascii	"android/view/animation/Interpolator"
	.zero	50

	/* #188 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554496
	/* java_name */
	.ascii	"android/widget/Adapter"
	.zero	63

	/* #189 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554489
	/* java_name */
	.ascii	"android/widget/AdapterView"
	.zero	59

	/* #190 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554491
	/* java_name */
	.ascii	"android/widget/AdapterView$OnItemSelectedListener"
	.zero	36

	/* #191 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554493
	/* java_name */
	.ascii	"android/widget/FrameLayout"
	.zero	59

	/* #192 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554494
	/* java_name */
	.ascii	"android/widget/HorizontalScrollView"
	.zero	50

	/* #193 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554497
	/* java_name */
	.ascii	"android/widget/ImageButton"
	.zero	59

	/* #194 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554498
	/* java_name */
	.ascii	"android/widget/ImageView"
	.zero	61

	/* #195 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554500
	/* java_name */
	.ascii	"android/widget/SpinnerAdapter"
	.zero	56

	/* #196 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554445
	/* java_name */
	.ascii	"crc64a0e0a82d0db9a07d/ActivityLifecycleContextListener"
	.zero	31

	/* #197 */
	/* module_index */
	.long	10
	/* type_token_id */
	.long	33554434
	/* java_name */
	.ascii	"crc64b46f3de153b37c9d/MainActivity"
	.zero	51

	/* #198 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554855
	/* java_name */
	.ascii	"java/io/Closeable"
	.zero	68

	/* #199 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554851
	/* java_name */
	.ascii	"java/io/File"
	.zero	73

	/* #200 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554852
	/* java_name */
	.ascii	"java/io/FileDescriptor"
	.zero	63

	/* #201 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554853
	/* java_name */
	.ascii	"java/io/FileInputStream"
	.zero	62

	/* #202 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554857
	/* java_name */
	.ascii	"java/io/Flushable"
	.zero	68

	/* #203 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554860
	/* java_name */
	.ascii	"java/io/IOException"
	.zero	66

	/* #204 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554858
	/* java_name */
	.ascii	"java/io/InputStream"
	.zero	66

	/* #205 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554863
	/* java_name */
	.ascii	"java/io/OutputStream"
	.zero	65

	/* #206 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554865
	/* java_name */
	.ascii	"java/io/PrintWriter"
	.zero	66

	/* #207 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554862
	/* java_name */
	.ascii	"java/io/Serializable"
	.zero	65

	/* #208 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554866
	/* java_name */
	.ascii	"java/io/StringWriter"
	.zero	65

	/* #209 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554867
	/* java_name */
	.ascii	"java/io/Writer"
	.zero	71

	/* #210 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554820
	/* java_name */
	.ascii	"java/lang/Appendable"
	.zero	65

	/* #211 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554796
	/* java_name */
	.ascii	"java/lang/Boolean"
	.zero	68

	/* #212 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554797
	/* java_name */
	.ascii	"java/lang/Byte"
	.zero	71

	/* #213 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554821
	/* java_name */
	.ascii	"java/lang/CharSequence"
	.zero	63

	/* #214 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554798
	/* java_name */
	.ascii	"java/lang/Character"
	.zero	66

	/* #215 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554799
	/* java_name */
	.ascii	"java/lang/Class"
	.zero	70

	/* #216 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554815
	/* java_name */
	.ascii	"java/lang/ClassCastException"
	.zero	57

	/* #217 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554800
	/* java_name */
	.ascii	"java/lang/ClassNotFoundException"
	.zero	53

	/* #218 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554824
	/* java_name */
	.ascii	"java/lang/Cloneable"
	.zero	66

	/* #219 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554826
	/* java_name */
	.ascii	"java/lang/Comparable"
	.zero	65

	/* #220 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554801
	/* java_name */
	.ascii	"java/lang/Double"
	.zero	69

	/* #221 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554816
	/* java_name */
	.ascii	"java/lang/Enum"
	.zero	71

	/* #222 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554818
	/* java_name */
	.ascii	"java/lang/Error"
	.zero	70

	/* #223 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554802
	/* java_name */
	.ascii	"java/lang/Exception"
	.zero	66

	/* #224 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554803
	/* java_name */
	.ascii	"java/lang/Float"
	.zero	70

	/* #225 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554829
	/* java_name */
	.ascii	"java/lang/IllegalArgumentException"
	.zero	51

	/* #226 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554830
	/* java_name */
	.ascii	"java/lang/IllegalStateException"
	.zero	54

	/* #227 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554831
	/* java_name */
	.ascii	"java/lang/IndexOutOfBoundsException"
	.zero	50

	/* #228 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554805
	/* java_name */
	.ascii	"java/lang/Integer"
	.zero	68

	/* #229 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554828
	/* java_name */
	.ascii	"java/lang/Iterable"
	.zero	67

	/* #230 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554834
	/* java_name */
	.ascii	"java/lang/LinkageError"
	.zero	63

	/* #231 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554806
	/* java_name */
	.ascii	"java/lang/Long"
	.zero	71

	/* #232 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554835
	/* java_name */
	.ascii	"java/lang/NoClassDefFoundError"
	.zero	55

	/* #233 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554836
	/* java_name */
	.ascii	"java/lang/NullPointerException"
	.zero	55

	/* #234 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554837
	/* java_name */
	.ascii	"java/lang/Number"
	.zero	69

	/* #235 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554807
	/* java_name */
	.ascii	"java/lang/Object"
	.zero	69

	/* #236 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554839
	/* java_name */
	.ascii	"java/lang/ReflectiveOperationException"
	.zero	47

	/* #237 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554833
	/* java_name */
	.ascii	"java/lang/Runnable"
	.zero	67

	/* #238 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554808
	/* java_name */
	.ascii	"java/lang/RuntimeException"
	.zero	59

	/* #239 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554809
	/* java_name */
	.ascii	"java/lang/Short"
	.zero	70

	/* #240 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554810
	/* java_name */
	.ascii	"java/lang/String"
	.zero	69

	/* #241 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554812
	/* java_name */
	.ascii	"java/lang/Thread"
	.zero	69

	/* #242 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554814
	/* java_name */
	.ascii	"java/lang/Throwable"
	.zero	66

	/* #243 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554840
	/* java_name */
	.ascii	"java/lang/UnsupportedOperationException"
	.zero	46

	/* #244 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554842
	/* java_name */
	.ascii	"java/lang/annotation/Annotation"
	.zero	54

	/* #245 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554844
	/* java_name */
	.ascii	"java/lang/reflect/AnnotatedElement"
	.zero	51

	/* #246 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554846
	/* java_name */
	.ascii	"java/lang/reflect/GenericDeclaration"
	.zero	49

	/* #247 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554848
	/* java_name */
	.ascii	"java/lang/reflect/Type"
	.zero	63

	/* #248 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554850
	/* java_name */
	.ascii	"java/lang/reflect/TypeVariable"
	.zero	55

	/* #249 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554736
	/* java_name */
	.ascii	"java/net/ConnectException"
	.zero	60

	/* #250 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554738
	/* java_name */
	.ascii	"java/net/HttpURLConnection"
	.zero	59

	/* #251 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554740
	/* java_name */
	.ascii	"java/net/InetSocketAddress"
	.zero	59

	/* #252 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554741
	/* java_name */
	.ascii	"java/net/Proxy"
	.zero	71

	/* #253 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554742
	/* java_name */
	.ascii	"java/net/Proxy$Type"
	.zero	66

	/* #254 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554743
	/* java_name */
	.ascii	"java/net/ProxySelector"
	.zero	63

	/* #255 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554745
	/* java_name */
	.ascii	"java/net/SocketAddress"
	.zero	63

	/* #256 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554747
	/* java_name */
	.ascii	"java/net/SocketException"
	.zero	61

	/* #257 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554748
	/* java_name */
	.ascii	"java/net/URI"
	.zero	73

	/* #258 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554749
	/* java_name */
	.ascii	"java/net/URL"
	.zero	73

	/* #259 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554750
	/* java_name */
	.ascii	"java/net/URLConnection"
	.zero	63

	/* #260 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554772
	/* java_name */
	.ascii	"java/nio/Buffer"
	.zero	70

	/* #261 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554774
	/* java_name */
	.ascii	"java/nio/ByteBuffer"
	.zero	66

	/* #262 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554779
	/* java_name */
	.ascii	"java/nio/channels/ByteChannel"
	.zero	56

	/* #263 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554781
	/* java_name */
	.ascii	"java/nio/channels/Channel"
	.zero	60

	/* #264 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554776
	/* java_name */
	.ascii	"java/nio/channels/FileChannel"
	.zero	56

	/* #265 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554783
	/* java_name */
	.ascii	"java/nio/channels/GatheringByteChannel"
	.zero	47

	/* #266 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554785
	/* java_name */
	.ascii	"java/nio/channels/InterruptibleChannel"
	.zero	47

	/* #267 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554787
	/* java_name */
	.ascii	"java/nio/channels/ReadableByteChannel"
	.zero	48

	/* #268 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554789
	/* java_name */
	.ascii	"java/nio/channels/ScatteringByteChannel"
	.zero	46

	/* #269 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554791
	/* java_name */
	.ascii	"java/nio/channels/SeekableByteChannel"
	.zero	48

	/* #270 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554793
	/* java_name */
	.ascii	"java/nio/channels/WritableByteChannel"
	.zero	48

	/* #271 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554794
	/* java_name */
	.ascii	"java/nio/channels/spi/AbstractInterruptibleChannel"
	.zero	35

	/* #272 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554759
	/* java_name */
	.ascii	"java/security/KeyStore"
	.zero	63

	/* #273 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554761
	/* java_name */
	.ascii	"java/security/KeyStore$LoadStoreParameter"
	.zero	44

	/* #274 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554763
	/* java_name */
	.ascii	"java/security/KeyStore$ProtectionParameter"
	.zero	43

	/* #275 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554758
	/* java_name */
	.ascii	"java/security/Principal"
	.zero	62

	/* #276 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554764
	/* java_name */
	.ascii	"java/security/SecureRandom"
	.zero	59

	/* #277 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554765
	/* java_name */
	.ascii	"java/security/cert/Certificate"
	.zero	55

	/* #278 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554767
	/* java_name */
	.ascii	"java/security/cert/CertificateFactory"
	.zero	48

	/* #279 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554770
	/* java_name */
	.ascii	"java/security/cert/X509Certificate"
	.zero	51

	/* #280 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554769
	/* java_name */
	.ascii	"java/security/cert/X509Extension"
	.zero	53

	/* #281 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554704
	/* java_name */
	.ascii	"java/util/ArrayList"
	.zero	66

	/* #282 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554693
	/* java_name */
	.ascii	"java/util/Collection"
	.zero	65

	/* #283 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554753
	/* java_name */
	.ascii	"java/util/Enumeration"
	.zero	64

	/* #284 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554695
	/* java_name */
	.ascii	"java/util/HashMap"
	.zero	68

	/* #285 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554713
	/* java_name */
	.ascii	"java/util/HashSet"
	.zero	68

	/* #286 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554755
	/* java_name */
	.ascii	"java/util/Iterator"
	.zero	67

	/* #287 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554756
	/* java_name */
	.ascii	"java/util/Random"
	.zero	69

	/* #288 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554464
	/* java_name */
	.ascii	"javax/net/SocketFactory"
	.zero	62

	/* #289 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554469
	/* java_name */
	.ascii	"javax/net/ssl/HostnameVerifier"
	.zero	55

	/* #290 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554466
	/* java_name */
	.ascii	"javax/net/ssl/HttpsURLConnection"
	.zero	53

	/* #291 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554471
	/* java_name */
	.ascii	"javax/net/ssl/KeyManager"
	.zero	61

	/* #292 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554480
	/* java_name */
	.ascii	"javax/net/ssl/KeyManagerFactory"
	.zero	54

	/* #293 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554481
	/* java_name */
	.ascii	"javax/net/ssl/SSLContext"
	.zero	61

	/* #294 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554473
	/* java_name */
	.ascii	"javax/net/ssl/SSLSession"
	.zero	61

	/* #295 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554475
	/* java_name */
	.ascii	"javax/net/ssl/SSLSessionContext"
	.zero	54

	/* #296 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554482
	/* java_name */
	.ascii	"javax/net/ssl/SSLSocketFactory"
	.zero	55

	/* #297 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554477
	/* java_name */
	.ascii	"javax/net/ssl/TrustManager"
	.zero	59

	/* #298 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554484
	/* java_name */
	.ascii	"javax/net/ssl/TrustManagerFactory"
	.zero	52

	/* #299 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554479
	/* java_name */
	.ascii	"javax/net/ssl/X509TrustManager"
	.zero	55

	/* #300 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"javax/security/cert/Certificate"
	.zero	54

	/* #301 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554462
	/* java_name */
	.ascii	"javax/security/cert/X509Certificate"
	.zero	50

	/* #302 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554890
	/* java_name */
	.ascii	"mono/android/TypeManager"
	.zero	61

	/* #303 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554689
	/* java_name */
	.ascii	"mono/android/runtime/InputStreamAdapter"
	.zero	46

	/* #304 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"mono/android/runtime/JavaArray"
	.zero	55

	/* #305 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554710
	/* java_name */
	.ascii	"mono/android/runtime/JavaObject"
	.zero	54

	/* #306 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554728
	/* java_name */
	.ascii	"mono/android/runtime/OutputStreamAdapter"
	.zero	45

	/* #307 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"mono/android/support/design/widget/SwipeDismissBehavior_OnDismissListenerImplementor"
	.zero	1

	/* #308 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554445
	/* java_name */
	.ascii	"mono/android/support/v4/app/FragmentManager_OnBackStackChangedListenerImplementor"
	.zero	4

	/* #309 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"mono/android/support/v4/view/ActionProvider_SubUiVisibilityListenerImplementor"
	.zero	7

	/* #310 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554446
	/* java_name */
	.ascii	"mono/android/support/v4/view/ActionProvider_VisibilityListenerImplementor"
	.zero	12

	/* #311 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"mono/android/support/v4/widget/DrawerLayout_DrawerListenerImplementor"
	.zero	16

	/* #312 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554441
	/* java_name */
	.ascii	"mono/android/support/v7/app/ActionBar_OnMenuVisibilityListenerImplementor"
	.zero	12

	/* #313 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554467
	/* java_name */
	.ascii	"mono/android/support/v7/widget/Toolbar_OnMenuItemClickListenerImplementor"
	.zero	12

	/* #314 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554504
	/* java_name */
	.ascii	"mono/android/view/View_OnClickListenerImplementor"
	.zero	36

	/* #315 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554813
	/* java_name */
	.ascii	"mono/java/lang/RunnableImplementor"
	.zero	51

	/* #316 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554456
	/* java_name */
	.ascii	"xamarin/android/net/OldAndroidSSLSocketFactory"
	.zero	39

	.size	map_java, 29481
/* Java to managed map: END */

