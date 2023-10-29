

const countdownElement = document.getElementById("countdown");

// Hàm tính toán thời gian còn lại cho Flash Sale
function updateCountdown() {
    const now = new Date();
    const saleStart = new Date(now.getFullYear(), now.getMonth(), now.getDate(), 13, 0, 0); // Thời gian bắt đầu (13:00 PM)
    const saleEnd = new Date(now.getFullYear(), now.getMonth(), now.getDate(), 16, 0, 0); // Thời gian kết thúc (16:00 PM)

    if (now < saleStart) {
        // Flash Sale chưa bắt đầu
        const timeUntilStart = saleStart - now;
        const hoursUntilStart = Math.floor(timeUntilStart / (1000 * 60 * 60));
        const minutesUntilStart = Math.floor((timeUntilStart % (1000 * 60 * 60)) / (1000 * 60));
        const secondsUntilStart = Math.floor((timeUntilStart % 60000) / 1000);

        countdownElement.textContent = `bắt đầu sau: ${hoursUntilStart}:${minutesUntilStart}:${secondsUntilStart}`;
    } else if (now < saleEnd) {
        // Flash Sale đang diễn ra
        const timeUntilEnd = saleEnd - now;
        const hoursUntilEnd = Math.floor(timeUntilEnd / (1000 * 60 * 60));
        const minutesUntilEnd = Math.floor((timeUntilEnd % (1000 * 60 * 60)) / (1000 * 60));
        const secondsUntilEnd = Math.floor((timeUntilEnd % 60000) / 1000);
        countdownElement.textContent = `kết thúc sau ${hoursUntilEnd}:${minutesUntilEnd}:${secondsUntilEnd} `;
    } else {
        // Flash Sale đã kết thúc
        countdownElement.textContent = " đã kết thúc!";
    }
}

// Cập nhật đồng hồ đếm ngược mỗi giây
setInterval(updateCountdown, 1000);

// Đảm bảo đồng hồ đếm ngược được cập nhật ngay khi trang web được tải
updateCountdown();