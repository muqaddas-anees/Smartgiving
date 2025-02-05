Ext.define('Gnt.examples.advanced.view.MainViewportController', {
    extend : 'Ext.app.ViewController',
    alias  : 'controller.advanced-viewport',

    requires : ['Gnt.widget.calendar.CalendarManagerWindow'],

    control : {
        '#'                             : { afterrender : 'onAfterRender' },
        'tool[reference]'               : { click : 'onButtonClick', priority : 1000 },
        '[reference=gantt]'             : { selectionchange : 'onGanttSelectionChange' },
        '[reference=shiftPrevious]'     : { click : 'onShiftPrevious' },
        '[reference=shiftNext]'         : { click : 'onShiftNext' },
        '[reference=collapseAll]'       : { click : 'onCollapseAll' },
        '[reference=expandAll]'         : { click : 'onExpandAll' },
        '[reference=zoomOut]'           : { click : 'onZoomOut' },
        '[reference=zoomIn]'            : { click : 'onZoomIn' },
        '[reference=zoomToFit]'         : { click : 'onZoomToFit' },
        '[reference=undo]'              : { click : 'onUndo' },
        '[reference=redo]'              : { click : 'onRedo' },
        '[reference=viewFullScreen]'    : { click : 'onFullScreen' },
        '[reference=criticalPath]'      : { click : 'onHighlightCriticalPath' },
        '[reference=addTask]'           : { click : 'onAddTask' },
        '[reference=removeSelected]'    : { click : 'onRemoveSelectedTasks' },
        '[reference=indentTask]'        : { click : 'onIndent' },
        '[reference=outdentTask]'       : { click : 'onOutdent' },
        '[reference=manageCalendars]'   : { click : 'onManageCalendars' },
        '[reference=saveChanges]'       : { click : 'onSaveChanges' },
        '[reference=toggleGrouping]'    : { click : 'onToggleGrouping' },
        '[reference=toggleRollup]'      : { click : 'onToggleRollup' },
        '[reference=highlightLong]'     : { click : 'onHighlightLongTasks' },
        '[reference=filterTasks]'       : { click : 'onFilterTasks' },
        '[reference=clearTasksFilter]'  : { click : 'onClearTasksFilter' },
        '[reference=scrollToLast]'      : { click : 'onScrollToLast' },
        '[reference=tryMore]'           : { click : 'onTryMore' },
        '[reference=print]'             : { click : 'onPrint' },
        'combo[reference=langSelector]' : { select : 'onLanguageSelected' },
        'gantt_timelinescheduler'       : { eventclick : 'onTimelineEventClick' }
    },

    getSelectedTasks    : function () {
        var tasks = [];

        if (this.getViewModel().get('hasSelection')) {
            var selected = this.getGantt().getSelectionModel().getSelected();

            if (selected instanceof Ext.grid.selection.Rows) {
                tasks = selected.getRecords();
            } else if (selected instanceof Ext.grid.selection.Cells) {
                selected.eachRow(function (record) {
                    tasks.push(record);
                });
            }
        }

        return tasks;
    },

    getGantt : function () {
        return this.getView().lookupReference('gantt');
    },

    onButtonClick : function() {
        // stop editing process before changing the UI
        this.getGantt().cancelEdit();
    },

    onGanttSelectionChange : function (grid, selection) {
        this.getViewModel().set('hasSelection', !!selection.getCount());
    },

    onShiftPrevious : function () {
        this.getGantt().shiftPrevious();
    },

    onShiftNext : function () {
        this.getGantt().shiftNext();
    },

    onCollapseAll : function () {
        this.getGantt().collapseAll();
    },

    onExpandAll : function () {
        this.getGantt().expandAll();
    },

    onZoomOut : function () {
        this.getGantt().zoomOut();
    },

    onZoomIn : function () {
        this.getGantt().zoomIn();
    },

    onZoomToFit : function () {
        this.getGantt().zoomToFit(null, { leftMargin : 100, rightMargin : 100 });
    },

    onUndo : function() {
        this.getViewModel().get('undoManager').undo();
    },

    onRedo : function() {
        this.getViewModel().get('undoManager').redo();
    },

    onFullScreen : function () {
        this.getGantt().getEl().down('.x-panel-body').dom[this.getFullscreenFn()](Element.ALLOW_KEYBOARD_INPUT);
    },

    // Experimental, not X-browser
    getFullscreenFn : function () {
        var docElm = document.documentElement,
            fn;

        if (docElm.requestFullscreen) {
            fn = "requestFullscreen";
        }
        else if (docElm.mozRequestFullScreen) {
            fn = "mozRequestFullScreen";
        }
        else if (docElm.webkitRequestFullScreen) {
            fn = "webkitRequestFullScreen";
        }
        else if (docElm.msRequestFullscreen) {
            fn = "msRequestFullscreen";
        }

        return fn;
    },

    onHighlightCriticalPath : function (btn) {
        var v = this.getGantt().getSchedulingView();

        btn.pressed = !btn.pressed;

        if (btn.pressed) {
            v.highlightCriticalPaths(true);
        } else {
            v.unhighlightCriticalPaths(true);
        }
    },

    onAddTask: function () {
        var cnt = this.getGantt().store.getCount();
        var node = this.getGantt().getSchedulingView().store.last();
        //alert(getQuerystring('project'));
        debugger;
        if (node == null) {
            //Gnt.examples.advanced.model.Task
            var newTask1 = new Gnt.examples.advanced.model.Task({
                Name: 'New Task',
                ProjectReference : getQuerystring('project'),
                //StartDate: start,

                leaf: true
            });
            //var record = node.appendChild({
            //    Name: 'New Task',
            //    leaf: true
            //});
            // var record = this.getGantt().getRootNode().appendChild(newTask1);
            this.getGantt().getRootNode().appendChild(newTask1);
            this.getGantt().lockedGrid.view.focusCell({ column: 1, row: cnt });
            //this.parentNode.appendChild(task);
            //this.getGantt().parentNode.appendChild(newTask1)
            //task = new this.self();

            //if (this.nextSibling) {
            //    return this.parentNode.insertBefore(task, this.nextSibling);
            //} else {
            //    return this.parentNode.appendChild(task);
            //}
            //var newTask1 = new taskStore.model({
            //    Name: 'New task',
            //    leaf: true,
            //    PercentDone: 0,
            //    StartDate: start,
            //    EndDate: Sch.util.Date.add(start, Sch.util.Date.DAY, 1),
            //    Duration: 1,
            //    DurationUnit: 'd',
            //    ListPosition: 1
            //});
            // g.getRootNode().appendChild(newTask1);
            // g.lockedGrid.view.focusCell({ column: 1, row: cnt });
            //var gantt = this.getGantt(),
            //   tasks = this.getSelectedTasks(),
            //   selectedTask = newTask1,
            //   editingInterface = gantt.lockedGrid.getPlugin('editingInterface'),
            //   node = selectedTask.isLeaf() ? selectedTask.parentNode : selectedTask;

            //var record = node.appendChild({
            //    Name: 'New Task',
            //    leaf: true
            //});
            debugger;
            //editingInterface.completeEdit();

            this.getGantt().getSchedulingView().scrollEventIntoView(record, false, false, function () {
                this.getGantt().getSelectionModel().select(record);

                // HACK: Ext JS editing process doesn't align cell editor properly after scrolling/selecting
                setTimeout(function () {
                    this.getGantt().lockedGrid.getPlugin('editingInterface').startEdit(record, 1);
                }, 20);
            });
        }
        else {
            // tasks[0]
            var gantt = this.getGantt(),
           tasks = this.getSelectedTasks(),
           selectedTask = node,
           editingInterface = gantt.lockedGrid.getPlugin('editingInterface'),
           node = selectedTask.isLeaf() ? selectedTask.parentNode : selectedTask;

            var record = node.appendChild({
                Name: 'New Task',
                leaf: true
            });

            editingInterface.completeEdit();

            gantt.getSchedulingView().scrollEventIntoView(record, false, false, function () {
                gantt.getSelectionModel().select(record);

                // HACK: Ext JS editing process doesn't align cell editor properly after scrolling/selecting
                setTimeout(function () {
                    gantt.lockedGrid.getPlugin('editingInterface').startEdit(record, 1);
                }, 20);
            });
        }
    },

    onRemoveSelectedTasks : function () {
        this.getGantt().getTaskStore().removeTasks(this.getSelectedTasks());
    },

    onIndent : function () {
        var gantt = this.getGantt();

        // filter out attempts to get into a readonly task
        var tasks = Ext.Array.filter(this.getSelectedTasks(), function (task) {
            return task.previousSibling && !task.previousSibling.isReadOnly();
        });

        gantt.getTaskStore().indent([].concat(tasks));
    },

    onOutdent : function () {
        var gantt = this.getGantt();

        // filter out readonly tasks
        var tasks = Ext.Array.filter(this.getSelectedTasks(), function (task) { return !task.isReadOnly(); });

        gantt.getTaskStore().outdent([].concat(tasks));
    },

    onSaveChanges : function () {
        this.getGantt().crudManager.sync();
    },

    onLanguageSelected : function (field, record) {
        this.fireEvent('locale-change', record.get('id'), record);
    },

    onToggleGrouping : function () {
        var taPlugin = this.getGantt().getPlugin('taskarea');
        taPlugin.setEnabled(!taPlugin.getEnabled());
    },

    onToggleRollup : function () {
        var gantt = this.getGantt();
        gantt.setShowRollupTasks(!gantt.showRollupTasks);
    },

    onHighlightLongTasks : function () {
        var gantt = this.getGantt();

        gantt.taskStore.queryBy(function (task) {
            if (task.data.leaf && task.getDuration() > 8) {
                var el = gantt.getSchedulingView().getElementFromEventRecord(task);
                el && el.frame('lime');
            }
        });
    },

    onFilterTasks : function () {
        this.getGantt().taskStore.filterTreeBy(function (task) {
            return task.getPercentDone() <= 30;
        });
    },

    onClearTasksFilter : function () {
        this.getGantt().taskStore.clearTreeFilter();
    },

    onScrollToLast : function () {
        var latestEndDate = new Date(0),
            gantt         = this.getGantt(),
            latest;

        gantt.taskStore.getRoot().cascadeBy(function (task) {
            if (task.get('EndDate') >= latestEndDate) {
                latestEndDate = task.get('EndDate');
                latest        = task;
            }
        });
        gantt.getSchedulingView().scrollEventIntoView(latest, true);
    },

    onAfterRender : function () {
        var me        = this,
            viewModel = me.getViewModel(),
            taskStore = viewModel.get('taskStore');

        viewModel.set('fullscreenEnabled', !!this.getFullscreenFn());

        me.mon(taskStore, 'filter-set', function () {
            viewModel.set('filterSet', true);
        });
        me.mon(taskStore, 'filter-clear', function () {
            viewModel.set('filterSet', false);
        });

        // track CRUD manager changes
        me.mon(viewModel.get('crud'), {
            haschanges : function () {
                me.getViewModel().set('hasChanges', true);
            },
            nochanges : function () {
                me.getViewModel().set('hasChanges', false);
            }
        });

        // track UNDO manager changes
        me.mon(viewModel.get('undoManager'), {
            undoqueuechange : function(undoManager, queue) {
                me.getViewModel().set('canUndo', queue.length > 0);
            },
            redoqueuechange : function(undoManager, queue) {
                me.getViewModel().set('canRedo', queue.length > 0);
            }
        });

        viewModel.get('undoManager').start();
    },

    onManageCalendars : function () {
        var gantt = this.getGantt();

        this.calendarsWindow = new Gnt.widget.calendar.CalendarManagerWindow({
            calendarManager : gantt.getTaskStore().calendarManager,
            maximized       : true,
            modal           : true
        });

        this.calendarsWindow.show();
    },

    onTryMore : function () {
        var tbar = this.getView().down('gantt-secondary-toolbar');

        tbar.setVisible(!tbar.isVisible());
    },

    onTimelineEventClick : function(panel, task) {
        this.getGantt().getSchedulingView().scrollEventIntoView(task);
    },

    onPrint : function () {
        this.getGantt().print();
    }
});
