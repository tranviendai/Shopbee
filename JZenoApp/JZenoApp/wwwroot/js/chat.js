var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
document.getElementById("sendButton").disabled = true;
loadData();
function loadData() {
    var chatid = $('#chatId').val();
    var divMessage = '';
    var userId = $("#userId").val();
    $.ajax({
        method: "GET",
        url: "/Chat/GetMessage/" + chatid,
        dataType: "json",
        success: function (data) {
            $.each(data, function (i, item) {
                var className = item.senderId != userId ? 'message receiver' : 'message sender';
                var classNameImg = item.senderId == userId ? 'display:none;' : 'display:block';
                divMessage = divMessage +
                    `<div class="${className}"><p style="${classNameImg}"></p><div> <span>${item.message}</span></div></div>`;
            });
            $("#messagesList").html(divMessage.split("\n").join("<br>"));
            $('#messagesList').scrollTop($('#messagesList')[0].scrollHeight);
        }
    });
}
connection.on("ReceiveMessage", function () {
    loadData();
});
connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});


document.getElementById("sendButton").addEventListener("click", function (event) {
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

$('textarea').each(function () {
    this.setAttribute('style', 'overflow-y:auto;');
    $("#sendButton").css("height", "12px");
}).on('input', function () {
    this.style.height = 'auto';
    this.style.height = (this.scrollHeight) + 'px';
    if (this.scrollHeight > 80) {
        this.style.height = '80px';
    }
    $("#sendButton").css("height", this.style.height);
});
$('textarea').on('keydown', function (event) {
    if (event.key === "Enter" && event.altKey) {
        this.value = this.value + "\r\n";
        this.style.height = (this.scrollHeight) + 'px';
        if (this.scrollHeight > 80) {
            this.style.height = '80px';
        }
        $("#sendButton").css("height", this.style.height);
    } else if (event.key === "Enter" && event.shiftKey) {
        this.style.height = (this.scrollHeight) + 'px';
        if (this.scrollHeight > 80) {
            this.style.height = '80px';
        }
        $("#sendButton").css("height", this.style.height);
    }
    else if (event.key === "Enter") {
        event.preventDefault();
        document.getElementById("sendButton").click();
    }
});
$("#sendButton").on("click", function () {
    var message = $('#messageInput').val();
    var id = $('#chatId').val();
    if (message.trim() != '') {
        $.ajax({
            method: "POST",
            url: "/Chat/AddMessage",
            data: {
                chatMessage: message,
                chatId: id
            },
            dataType: "json",
            success: function (data) {
                $('#messageInput').val(null);
            }
        });
    }
});
