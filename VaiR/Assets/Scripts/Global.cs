using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Global : MonoBehaviour
{
	
	public static int count = 0;
	public static int incorrectClickCounter = 0;
	public static int itemSize = 3;
	public static string[,] currentScenario;
	public static string mode;
	public Text buttonClickedText;

	public static void setScenario (int id)
	{
		switch (id) {
		case 0:
			currentScenario = new string[,] {
				{"battery_guard", "button",
				"Next: BATTERY switch Guard closed"},

				{"electric_hydraulic_pumps", "button",
				"Next: ELECTRIC HYDRAULIC PUMPS switches OFF"},

				{"landing_gear", "button",
				"Next: LANDING GEAR lever DN"},

                {"landing_gear_lights", "gaze",
				"Verify green LANDING GEAR INDICATORS are lit"},

                {"landing_gear_lights", "gaze",
				"Verify red LANDING GEAR INDICATORS are unlit"},

                {"grd_power_available", "gaze",
				"Verify GRD POWER AVAILABLE light is lit."},

                {"grd_power",  "button",
				"Next: GRD POWER switch – ON"},

                // {"source_off_lights","Next: Verify that the SOURCE OFF lights are extinguished"},

                {"transfer_bus_lights", "gaze",
				"Verify that the TRANSFER BUS OFF lights are extinguished"},

                {"standby_pwr_off_lights", "gaze",
				"Verify that the STANDBY PWR OFF light is extinguished"},

				{"light_set", "button",
				"Next: LIGHT SET"},

				{"fire_1_apu", "gaze",
				"Verify that the engine No. 1, APU fire switches are in"},

				{"fire_2_apu", "gaze",
				"Verify that the engine No. 2, APU fire switches are in"},

				{"overheat_dtc_1", "button",
				"Next: OVERHEAT DETECTOR switches 1 – NORMAL"},

				{"overheat_dtc_2", "button",
				"Next: OVERHEAT DETECTOR switches 2 – NORMAL"},

				{"overheat_test", "button",
				"Next: TEST switch – Hold to FAULT/INOP"},

				{"master_caution", "gaze",
				"Verify that the MASTER CAUTION lights are illuminated"},

				{"annunciator", "gaze",
				"Verify that the OVHT/DET annunciator is illuminated"},

				{"fault_light", "gaze",
				"Verify that the FAULT light is illuminated"},

				{"apu_det_inop_light", "gaze",
				"Verify that the APU DET INOP light is illuminated"},

				{"overheat_test", "button",
				"Next: TEST switch – Hold to OVHT/FIRE"},

				{"master_fire_warn", "gaze",
				"Verify that the master FIRE WARN lights are illuminated"},

				{"master_caution", "gaze",
				"Verify that the MASTER CAUTION lights are illuminated"},

				{"annunciator", "gaze",
				"Verify that the OVHT/DET annunciator is illuminated"},

				{"master_fire_warn", "button",
				"Next: Master FIRE WARN light – Push"},

				{"master_fire_warn", "gaze",
				"Verify that the master FIRE WARN lights are extinguished."},

				{"fire_1_apu", "gaze",
				"Verify that the engine No. 1, APU fire switches stays illuminated"},

				{"fire_2_apu", "gaze",
				"Verify that the engine No. 2, APU fire switches stays illuminated"},
				
				{"wheel_well", "gaze",
				"Verify that the WHEEL WELL fire warning light is illuminated"},
				
				{"eng_1_overheat", "gaze",
				"Verify that the ENG 1 OVERHEAT light stay illuminated"},
				
				{"eng_2_overheat", "gaze",
				"Verify that the ENG 2 OVERHEAT light stay illuminated"},

				{"ext_test", "button",
				"Next: EXTINGUISHER TEST Switch - Position to 1 and hold"},
				
				{"test_lights", "gaze",
				"Verify that the three green extinguisher test lights are extinguished"},
				
				{"ext_test", "button",
				"Next: EXTINGUISHER TEST Switch - Position to 2 and hold"},
				
				{"test_lights", "gaze",
				"Verify that the three green extinguisher test lights are extinguished"},

				{"detector_select_switches", "button",
				"Next: DETECTOR SELECT switches – NORM"},

				{"cargo_fire_test", "button",
				"Next: TEST switch – Push"},

				{"master_fire_warn", "gaze",
				"Verify that the master FIRE WARN lights are illuminated"},

				{"master_fire_warn", "button",
				"Next: Master FIRE WARN light – Push"},

				{"master_fire_warn", "gaze",
				"Verify that the master FIRE WARN lights are extinguished"},

				{"fwd_aft_det_fault_lights", "gaze",
				"Verify that the FWD and AFT lights stay illuminated"},

				{"fwd_aft_det_fault_lights", "gaze",
				"Verify that the DETECTOR FAULT light stays extinguished"},

				{"test_lights", "gaze",
				"Verify that the green EXTINGUISHER test lights stay illuminated"},

				// {"disch", "gaze", // @ToDo
				// "Verify that the DISCH light stays illuminated"},

				{"apu_start", "button",
				"Next: APU – Start if needed."},

				{"transfer_bus_lights", "gaze",
				"Verify that the TRANSFER BUS OFF lights are extinguished"},

				{"standby_pwr_off_lights", "gaze",
				"Verify that the STANDBY PWR OFF light is extinguished"},

				{"maint_oil_fault_speed", "gaze",
				"Verify that the APU MAINT light is extinguished"},
				
				{"maint_oil_fault_speed", "gaze",
				"Verify that the APU LOW OIL PRESSURE light is extinguished"},

				{"maint_oil_fault_speed", "gaze",
				"Verify that the APU FAULT light is extinguished"},

				{"maint_oil_fault_speed", "gaze",
				"Verify that the APU OVERSPEED light is extinguished"},

				{"apu_gen_bus_2", "button",
				"Next: APU GENERATOR bus switches 2 - ON"},

				{"apu_gen_bus_3", "button",
				"Next: APU GENERATOR bus switches 3 - ON"}};
			break;
		default:
			print ("Incorrect parameter");
			break;

		}

	}
}
