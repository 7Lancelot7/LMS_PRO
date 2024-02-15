// Отримуємо поточний час та оновлюємо його кожну секунду
function updateTime() {
    var now = new Date();
    var hours = now.getHours();
    var minutes = now.getMinutes();
    var seconds = now.getSeconds();

    // Додаємо нуль, якщо число менше 10
    hours = (hours < 10) ? '0' + hours : hours;
    minutes = (minutes < 10) ? '0' + minutes : minutes;
    seconds = (seconds < 10) ? '0' + seconds : seconds;

    // Формуємо рядок з часом
    var timeString = hours + ':' + minutes + ':' + seconds;

    // Отримуємо елемент, де будемо відображати час
    var timeElement = document.getElementById('currentTime');

    // Встановлюємо текст елемента на поточний час
    timeElement.textContent = 'Поточний час: ' + timeString;
}

// Викликаємо функцію updateTime() кожну секунду
setInterval(updateTime, 1000);
