
const countdownElement = document.getElementById("countdown");

// Hàm tính toán thời gian còn lại cho Flash Sale
function updateCountdown() {
    const now = new Date();
    const saleStart = new Date(now.getFullYear(), now.getMonth(), now.getDate(), 19, 0, 0); // Thời gian bắt đầu (20:00 PM)
    const saleEnd = new Date(now.getFullYear(), now.getMonth(), now.getDate(), 23, 0, 0); // Thời gian kết thúc (22:00 PM)

    if (now < saleStart) {
        // Flash Sale chưa bắt đầu
        const timeUntilStart = saleStart - now;
        const hoursUntilStart = Math.floor(timeUntilStart / (1000 * 60 * 60));
        const minutesUntilStart = Math.floor((timeUntilStart % (1000 * 60 * 60)) / (1000 * 60));
        // const secondsUntilStart = Math.floor(timeUntilStart / 1000);

        const secondsUntilStart = Math.floor((timeUntilStart % 60000) / 1000);

        countdownElement.textContent = `bắt đầu sau: ${hoursUntilStart}:${minutesUntilStart}:${secondsUntilStart }`;
    } else if (now < saleEnd) {
        // Flash Sale đang diễn ra
        const timeUntilEnd = saleEnd - now;
        const hoursUntilEnd = Math.floor(timeUntilEnd / (1000 * 60 * 60));
        const minutesUntilEnd = Math.floor((timeUntilEnd % (1000 * 60 * 60)) / (1000 * 60));
        // const secondsUntilEnd = Math.floor(timeUntilEnd / 1000);

        const secondsUntilEnd = Math.floor((timeUntilEnd % 60000) / 1000);

        countdownElement.textContent = `kết thúc sau ${hoursUntilEnd}:${minutesUntilEnd}:${secondsUntilEnd} `;
    } else {
        // Flash Sale đã kết thúc
        countdownElement.textContent = " đã kết thúc!";
    }
}

// Cập nhật đồng hồ đếm ngược mỗi phút
setInterval(updateCountdown, 1000);

// Đảm bảo đồng hồ đếm ngược được cập nhật ngay khi trang web được tải
updateCountdown();


// Thời gian kết thúc của flash sale (định dạng Unix timestamp)
const flashSaleEndTime = new Date().getTime() + 10000000; // Ví dụ: 10 phút từ thời điểm hiện tại

const countdownElement = document.getElementById("countdown");

function updateCountdown() {
    const currentTime = new Date().getTime();
    const timeRemaining = flashSaleEndTime - currentTime;

    if (timeRemaining <= 0) {
        countdownElement.textContent = "Flash Sale đã kết thúc!";
    } else {
        const hours = Math.floor(timeRemaining / 3600000);
        const minutes = Math.floor((timeRemaining % 3600000) / 60000);
        const seconds = Math.floor((timeRemaining % 60000) / 1000);

        countdownElement.textContent = `${padZero(hours)}:${padZero(minutes)}:${padZero(seconds)}`;
    }
}

function padZero(value) {
    return value < 10 ? `0${value}` : value;
}

// Cập nhật đồng hồ đếm ngược mỗi giây
const countdownInterval = setInterval(updateCountdown, 1000);

// Kiểm tra khi flash sale đã kết thúc và dừng đồng hồ đếm ngược
if (flashSaleEndTime <= new Date().getTime()) {
    clearInterval(countdownInterval);
    countdownElement.textContent = "Flash Sale đã kết thúc!";
}

