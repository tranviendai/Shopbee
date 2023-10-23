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
