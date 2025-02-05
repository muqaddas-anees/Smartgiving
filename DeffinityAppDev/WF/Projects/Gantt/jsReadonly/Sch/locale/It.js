// @tag alternative-locale
/**
 * Italian translations for the Scheduler component
 *
 * NOTE: To change locale for month/day names you have to use the corresponding Ext JS language file.
 */
Ext.define('Sch.locale.It', {
    extend      : 'Sch.locale.Locale',
    singleton   : true,

    constructor : function (config) {

        Ext.apply(this, {
            l10n        : {
                'Sch.util.Date' : {
                    unitNames : {
                        YEAR        : { single : 'anno',    plural : 'anni',   abbrev : 'anno' },
                        QUARTER     : { single : 'quadrimestre', plural : 'quadrimestri',abbrev : 'q' },
                        MONTH       : { single : 'mese',   plural : 'mesi',  abbrev : 'mese' },
                        WEEK        : { single : 'settimana',    plural : 'settimane',   abbrev : 'sett' },
                        DAY         : { single : 'giorno',     plural : 'giorni',    abbrev : 'g' },
                        HOUR        : { single : 'ora',    plural : 'ore',   abbrev : 'o' },
                        MINUTE      : { single : 'minuto',  plural : 'minuti', abbrev : 'min' },
                        SECOND      : { single : 'secondo',  plural : 'secondi', abbrev : 's' },
                        MILLI       : { single : 'ms',      plural : 'ms',      abbrev : 'ms' }
                    }
                },

                'Sch.panel.TimelineGridPanel' : {
                    weekStartDay : 1,
                    loadingText  : 'Caricamento in corso, attendere prego...',
                    savingText   : 'Saving changes, attendere prego...'
                },

                'Sch.panel.TimelineTreePanel' : {
                    weekStartDay : 1,
                    loadingText  : 'Caricamento in corso, attendere prego...',
                    savingText   : 'Saving changes, attendere prego...'
                },

                'Sch.mixin.SchedulerView' : {
                    loadingText : 'Caricamento eventi...'
                },

                'Sch.plugin.CurrentTimeLine' : {
                    tooltipText : 'Tempo attuale'
                },

                'Sch.plugin.EventEditor' : {
                    saveText    : 'Salva',
                    deleteText  : 'Elimina',
                    cancelText  : 'Annulla'
                },

                'Sch.plugin.SimpleEditor' : {
                    newEventText    : 'Nuova prenotazione...'
                },

                'Sch.widget.ExportDialogForm' : {
                    formatFieldLabel            : 'Formato Carta',
                    orientationFieldLabel       : 'Orientamento',
                    rangeFieldLabel             : 'Range di schedulatore',
                    showHeaderLabel             : 'Aggiungi numero pagina',
                    showFooterLabel             : 'Aggiungi footer',
                    orientationPortraitText     : 'Verticale',
                    orientationLandscapeText    : 'Orizzontale',
                    completeViewText            : 'Schedulatore completo',
                    currentViewText             : 'Vista attuale',
                    dateRangeText               : 'Range di date',
                    dateRangeFromText           : 'Esporta da',
                    dateRangeToText             : 'Esporta a',
                    adjustCols                  : 'Imposta larghezza colonna',
                    adjustColsAndRows           : 'Imposta larghezza colonna e altezza riga',
                    exportersFieldLabel         : 'Controllare l\'impaginazione',
                    specifyDateRange            : 'Specifica intervallo date',
                    columnPickerLabel           : 'Scegli colonne',
                    dpiFieldLabel               : 'DPI (punti per pollice)',
                    completeDataText            : 'Schedulatore completo (tutti gli eventi)',
                    rowsRangeLabel              : 'Range di riga',
                    allRowsLabel                : 'Tutte le righe',
                    visibleRowsLabel            : 'Righe visibili'
                },

                'Sch.widget.ExportDialog' : {
                    title                       : 'Impostazioni Esportazione',
                    exportButtonText            : 'Esporta',
                    cancelButtonText            : 'Annulla',
                    progressBarText             : 'Esporta...'
                },

                'Sch.plugin.Export' : {
                    generalError            : 'Si è verificato un errore',
                    fetchingRows            : 'Riga {0} di {1}',
                    builtPage               : 'Pagina {0} di {1}',
                    requestingPrintServer   : 'L\'invio dei dati...'
                },

                'Sch.plugin.Printable' : {
                    dialogTitle         : 'Preferenze stampa',
                    exportButtonText    : 'Stampa'
                },

                'Sch.plugin.exporter.AbstractExporter' : {
                    name    : 'Exporter'
                },

                'Sch.plugin.exporter.SinglePage' : {
                    name    : 'Pagina singola'
                },

                'Sch.plugin.exporter.MultiPageVertical' : {
                    name    : 'Più pagine (verticalmente)'
                },

                'Sch.plugin.exporter.MultiPage' : {
                    name    : 'Più pagine'
                },

                // -------------- View preset date formats/strings -------------------------------------
                'Sch.preset.Manager' : {
                    hourAndDay : {
                        displayDateFormat : 'G:i',
                        middleDateFormat : 'G:i',
                        topDateFormat : 'D d/m'
                    },

                    secondAndMinute : {
                        displayDateFormat : 'G:i',
                        topDateFormat : 'D, d/m G:i'
                    },

                    dayAndWeek : {
                        displayDateFormat : 'd/m h:i A',
                        middleDateFormat : 'D d M'
                    },

                    weekAndDay : {
                        displayDateFormat : 'd/m',
                        bottomDateFormat : 'd M',
                        middleDateFormat : 'Y F d'
                    },

                    weekAndMonth : {
                        displayDateFormat : 'd/m/Y',
                        middleDateFormat : 'd/m',
                        topDateFormat : 'd/m/Y'
                    },

                    weekAndDayLetter : {
                        displayDateFormat : 'd/m/Y',
                        middleDateFormat : 'D d M Y'
                    },

                    weekDateAndMonth : {
                        displayDateFormat : 'd/m/Y',
                        middleDateFormat : 'd',
                        topDateFormat : 'Y F'
                    },

                    monthAndYear : {
                        displayDateFormat : 'd/m/Y',
                        middleDateFormat : 'M Y',
                        topDateFormat : 'Y'
                    },

                    year : {
                        displayDateFormat : 'd/m/Y',
                        middleDateFormat : 'Y'
                    }
                }
            }
        });

        this.callParent(arguments);
    }
});
