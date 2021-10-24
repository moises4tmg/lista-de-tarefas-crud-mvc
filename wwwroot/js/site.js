// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Stript that allow the user to change the Task Status while he still in the Index page
$(document).ready(function(){ 
    $(".check-box").change(function(){
        var url = "/Tarefas/EditFlag/"+this.id;
        var id = this.id;
        var status;
        if($(this).is(":checked")){
            status = true;
        }else{
            status = false;
        }
        $.post(url, { Id: id, Status: status});
    });
});