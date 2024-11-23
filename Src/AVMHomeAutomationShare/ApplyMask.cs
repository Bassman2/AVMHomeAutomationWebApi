﻿

namespace AVMHomeAutomation;

/// <summary>
/// Subnodes depending on which configuration is set.
/// </summary>
public class ApplyMask
{
    /// <summary>
    /// HKR heating switch-off (in summer).
    /// </summary>
    [XmlElement("hkr_summer")]
    public bool HkrSummer { get; set; }

    /// <summary>
    /// HKR target temperature.
    /// </summary>
    [XmlElement("hkr_temperature")]
    public bool HkrTemperature { get; set; }

    /// <summary>
    /// HKR holiday bookings
    /// </summary>
    [XmlElement("hkr_holidays")]
    public bool HkrHolidays { get; set; }

    /// <summary>
    /// HKR time switch
    /// </summary>
    [XmlElement("hkr_time_table")]
    public bool HkrTimeTable { get; set; }

    /// <summary>
    /// Switchable socket/lamp/actuator ON/OFF.
    /// </summary>
    [XmlElement("relay_manual")]
    public bool RelayManual { get; set; }

    /// <summary>
    /// Switchable socket/lamp/roller shutter time switch.
    /// </summary>
    [XmlElement("relay_automatic")]
    public bool RelayAutomatic { get; set; }

    /// <summary>
    /// Level or brightness of lamp/roller shutter.
    /// </summary>
    [XmlElement("level")]
    public bool Level { get; set; }

    /// <summary>
    /// Color or color temperature.
    /// </summary>
    [XmlElement("color")]
    public bool Color { get; set; }

    /// <summary>
    /// Announcement.
    /// </summary>
    [XmlElement("dialhelper")]
    public bool Dialhelper { get; set; }

    /// <summary>
    /// Light sunrise and sunset simulation.
    /// </summary>
    /// <remarks>New in Fritz!OS 7.39</remarks>
    [XmlElement("sun_simulation")]
    public bool SunSimulation { get; set; }

    /// <summary>
    /// Grouped templates, scenarios.
    /// </summary>
    /// <remarks>New in Fritz!OS 7.39</remarks>
    [XmlElement("sub_templates")]
    public bool SubTemplates { get; set; }

    /// <summary>
    /// WIFI on/off
    /// </summary>
    /// <remarks>New in Fritz!OS 7.39</remarks>
    [XmlElement("main_wifi")]
    public bool MainWifi { get; set; }

    /// <summary>
    /// Guest WIFI on/off.
    /// </summary>
    /// <remarks>New in Fritz!OS 7.39</remarks>
    [XmlElement("guest_wifi")]
    public bool GuestWifi { get; set; }

    /// <summary>
    /// Answering machine on/off.
    /// </summary>
    /// <remarks>New in Fritz!OS 7.39</remarks>
    [XmlElement("tam_control")]
    public bool TamControl { get; set; }

    /// <summary>
    /// Send any HTTP request.
    /// </summary>
    /// <remarks>New in Fritz!OS 7.39</remarks>
    [XmlElement("http_request")]
    public bool HttpRequest { get; set; }

    /// <summary>
    /// Activate HKR Boost/window open/temperature override.
    /// </summary>
    /// <remarks>New in Fritz!OS 7.39</remarks>
    [XmlElement("timer_control")]
    public bool TimerControl { get; set; }

    /// <summary>
    /// Switch devices to state of other devices.
    /// </summary>
    /// <remarks>New in Fritz!OS 7.39</remarks>
    [XmlElement("switch_master")]
    public bool SwitchMaster { get; set; }

    /// <summary>
    /// TemplateTrigger pushmail/app notification.
    /// </summary>
    /// <remarks>New in Fritz!OS 7.39</remarks>
    [XmlElement("custom_notification")]
    public bool CustomNotification { get; set; }
}
