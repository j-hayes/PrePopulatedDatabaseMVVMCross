#include "monotouch/main.h"


void monotouch_register_modules ()
{

}

void monotouch_register_assemblies ()
{
	monotouch_open_and_register ("monotouch.dll");
	monotouch_open_and_register ("Cirrious.MvvmCross.Touch.dll");
	monotouch_open_and_register ("Cirrious.CrossCore.Touch.dll");
	monotouch_open_and_register ("Cirrious.MvvmCross.Binding.Touch.dll");

}

void monotouch_setup ()
{
	use_old_dynamic_registrar = FALSE;
	monotouch_enable_debug_tracking = TRUE;
	monotouch_assembly_name = "PrePopulatedDatabaseTouch.exe";
	monotouch_use_new_assemblies = 0;
	mono_use_llvm = FALSE;
	monotouch_log_level = 0;
	monotouch_debug_mode = TRUE;
	monotouch_new_refcount = FALSE;
	monotouch_sgen = FALSE;
}

int main (int argc, char **argv)
{
	NSAutoreleasePool *pool = [[NSAutoreleasePool alloc] init];
	int rv = monotouch_main (argc, argv, false);
	[pool drain];
	return rv;
}
