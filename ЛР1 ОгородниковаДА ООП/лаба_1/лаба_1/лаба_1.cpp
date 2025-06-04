#include <iostream>
#include <string>
#include <windows.h>
#include <vector> 

class Film {
protected:
    std::string scenario; // Сценарий фильма
    std::string montage; // Монтаж фильма

public:
    // Конструктор
    Film(const std::string& scenario, const std::string& montage) : scenario(scenario), montage(montage) {}

    virtual ~Film() {}

    // Геттер и сеттер для сценария 
    void setScenario(const std::string& scenario) { this->scenario = scenario; }
    std::string getScenario() const { return scenario; }

    // Геттер и сеттер для монтажа 
    void setMontage(const std::string& montage) { this->montage = montage; }
    std::string getMontage() const { return montage; }

    // Функция финансирования фильма
    void financing() {
        std::cout << "Получение финансирования для фильма..." << std::endl;
        std::cout << "Получение финансирования для фильма..." << std::endl;
        std::cout << "Финансирование получено." << std::endl;
    }

    // Функция съёмок фильма
    void filming() {
        std::cout << "Съёмки фильма..." << std::endl;
        std::cout << "Съёмки фильма..." << std::endl;
        std::cout << "Съёмки фильма..." << std::endl;
    }

    // Виртуальная функция воспроизведения звуков
    virtual void sounds() {
        std::cout << "Воспроизведение стандартных звуковых эффектов..." << std::endl;
        std::cout << "Воспроизведение стандартных звуковых эффектов..." << std::endl;
        std::cout << "Стандартные звуковые эффекты воспроизведены." << std::endl;
    }

    // Виртуальная функция воздействия на эмоции 
    virtual void emotions() {
        std::cout << "Стандартное воздействие на эмоции..." << std::endl;
        std::cout << "Стандартное воздействие на эмоции..." << std::endl;
        std::cout << "Воздействие на эмоции завершено." << std::endl;
    }

    // Виртуальная функция отображения информации о фильме
    virtual void displayInfo() {
        std::cout << "Общая информация о фильме:" << std::endl;
        std::cout << "  Сценарист: " << scenario << std::endl;
        std::cout << "  Режиссёр монтажа: " << montage << std::endl;
    }
};

class EntertainmentFilm : public Film {
private:
    std::string type; // Тип (жанр)
    std::string ageRestriction; // Возрастное ограничение

public:
    // Конструктор
    EntertainmentFilm(const std::string& scenario, const std::string& montage, const std::string& type, const std::string& ageRestriction)
        : Film(scenario, montage), type(type), ageRestriction(ageRestriction) {}

    ~EntertainmentFilm() override {}

    // Геттеры и сеттеры для типа и возрастного ограничения
    void setType(const std::string& type) { this->type = type; }
    std::string getType() const { return type; }

    void setAgeRestriction(const std::string& ageRestriction) { this->ageRestriction = ageRestriction; }
    std::string getAgeRestriction() const { return ageRestriction; }

    // Функция развлечения зрителя
    void entertain() {
        std::cout << "Развлечение зрителя..." << std::endl;
        std::cout << "Развлечение зрителя..." << std::endl;
        std::cout << "Развлечение зрителя..." << std::endl;
    }

    // Функция расслабления зрителя
    void relax() {
        std::cout << "Расслабление зрителя..." << std::endl;
        std::cout << "Расслабление зрителя..." << std::endl;
        std::cout << "Расслабление зрителя..." << std::endl;
    }

    // Переопределенная функция sounds()
    void sounds() override {
        std::cout << "Громкие звуки..." << std::endl;
        std::cout << "Громкие звуки..." << std::endl;
        std::cout << "Громкие звуки..." << std::endl;
    }

    // Переопределенная функция emotions()
    void emotions() override {
        std::cout << "Широкий спектр эмоций..." << std::endl;
        std::cout << "Широкий спектр эмоций..." << std::endl;
        std::cout << "Широкий спектр эмоций..." << std::endl;
    }

    // Переопределенная функция displayInfo()
    void displayInfo() override {
        Film::displayInfo();
        std::cout << "  Сценарист: " << scenario << std::endl;
        std::cout << "  Режиссёр монтажа: " << montage << std::endl;
        std::cout << "  Тип (жанр): " << type << std::endl;
        std::cout << "  Возрастное ограничение: " << ageRestriction << std::endl;
    }
};

class ScienceFilm : public Film {
private:
    std::string field; // Научная область
    std::string audience; // Целевая аудитория

public:
    // Конструктор
    ScienceFilm(const std::string& scenario, const std::string& montage, const std::string& field, const std::string& audience)
        : Film(scenario, montage), field(field), audience(audience) {}

    // Конструктор
    ScienceFilm(const std::string& scenario, const std::string& montage, const std::string& field)
        : Film(scenario, montage), field(field), audience("") {}

    ~ScienceFilm() override {}

    // Геттеры и сеттеры для научной области и целевой аудитории
    void setField(const std::string& field) { this->field = field; }
    std::string getField() const { return field; }

    void setAudience(const std::string& audience) { this->audience = audience; }
    std::string getAudience() const { return audience; }

    // Функция обучения зрителя
    void educate() {
        std::cout << "Обучение зрителя..." << std::endl;
        std::cout << "Обучение зрителя..." << std::endl;
        std::cout << "Обучение зрителя..." << std::endl;
    }

    // Функция мотивации зрителя
    void motivate() {
        std::cout << "Мотивация зрителя..." << std::endl;
        std::cout << "Мотивация зрителя..." << std::endl;
        std::cout << "Мотивация зрителя..." << std::endl;
    }

    // Переопределенная виртуальная функция для воспроизведения звуков
    void sounds() override {
        std::cout << "Спокойные ненавязчивые звуки..." << std::endl;
        std::cout << "Спокойные ненавязчивые звуки..." << std::endl;
        std::cout << "Спокойные ненавязчивые звуки..." << std::endl;
    }

    // Переопределенная виртуальная функция для воздействия на эмоции
    void emotions() override {
        std::cout << "Эмоции удивления, восхищения, размышления..." << std::endl;
        std::cout << "Эмоции удивления, восхищения, размышления..." << std::endl;
        std::cout << "Эмоции удивления, восхищения, размышления..." << std::endl;
    }

    // Переопределенная виртуальная функция для отображения информации
    void displayInfo() override {
        Film::displayInfo();
        std::cout << "  Научная область: " << field << std::endl;
        if (!audience.empty()) {
            std::cout << "  Аудитория: " << audience << std::endl;
        }
    }
};

// Функция для поиска продюсера фильма
void findProducer(Film* film) {
    if (film) {
        std::cout << "Поиск продюсера..." << std::endl;
        std::cout << "Продюсер найден." << std::endl;
        film->financing();
    }
    else {
        std::cout << "Сначала нужно создать фильм." << std::endl;
    }
}

// Функция для съёмки фильма
void filmMovie(Film* film) {
    if (film) {
        std::cout << "Начало съёмок фильма..." << std::endl;
        film->filming();
        std::cout << "Съёмки фильма завершены." << std::endl;
    }
    else {
        std::cout << "Сначала нужно создать фильм." << std::endl;
    }
}

int main() {
    SetConsoleOutputCP(1251);
    Film* currentFilm = nullptr;
    std::vector<Film*> films;

    int choice;
    do {
        std::cout << "\nМеню:" << std::endl;
        std::cout << "1. Снять фильм" << std::endl;
        std::cout << "2. Снять развлекательный фильм" << std::endl;
        std::cout << "3. Снять научный фильм" << std::endl;
        std::cout << "4. Найти продюсера" << std::endl;
        std::cout << "5. Отснять фильм" << std::endl;
        std::cout << "6. Воспроизвести звуки" << std::endl;
        std::cout << "7. Воздействовать на эмоции" << std::endl;
        std::cout << "8. Развлечь зрителя (только для развлекательных фильмов)" << std::endl;
        std::cout << "9. Расслабить зрителя (только для развлекательных фильмов)" << std::endl;
        std::cout << "10. Обучить зрителя (только для научных фильмов)" << std::endl;
        std::cout << "11. Мотивировать зрителя (только для научных фильмов)" << std::endl;
        std::cout << "12. Показать информацию о фильме" << std::endl;
        std::cout << "0. Выход" << std::endl;
        std::cout << "Выберите действие: ";
        std::cin >> choice;

        std::string scenario, montage, type, ageRestriction, field, audience;

        switch (choice) {
        case 1: {
            std::cout << "Введите сценариста: ";
            // Очистка буфера ввода от предыдущего ввода
            std::cin.ignore();
            std::getline(std::cin, scenario);
            std::cout << "Введите режиссёра монтажа: ";
            std::getline(std::cin, montage);

            // Освобождение памяти, занимаемой предыдущим фильмом
            if (currentFilm) delete currentFilm;
            // Создание нового объекта
            currentFilm = new Film(scenario, montage);
            std::cout << "Фильм создан." << std::endl;
            break;
        }
        case 2: {
            std::cout << "Введите сценариста: ";
            std::cin.ignore();
            std::getline(std::cin, scenario);
            std::cout << "Введите режиссёра монтажа: ";
            std::getline(std::cin, montage);
            std::cout << "Введите тип (жанр): ";
            std::cin.ignore();
            std::getline(std::cin, type);
            std::cout << "Введите возрастное ограничение: ";
            std::getline(std::cin, ageRestriction);

            currentFilm = new EntertainmentFilm(scenario, montage, type, ageRestriction);
            std::cout << "Развлекательный фильм создан." << std::endl;
            films.push_back(currentFilm);
            break;
        }
        case 3: {
            char yn;
            std::cout << "Введите сценариста: ";
            std::cin.ignore();
            std::getline(std::cin, scenario);
            std::cout << "Введите режиссёра монтажа: ";
            std::getline(std::cin, montage);
            std::cout << "Введите научную область: ";
            std::getline(std::cin, field);
            std::cout << "Хотите указать целевую аудиторию? (y/n): ";
            std::cin >> yn;

            if (yn == 'y' || yn == 'Y') {
                std::cin.ignore(); // Consume newline
                std::cout << "Введите аудиторию: ";
                std::getline(std::cin, audience);
                currentFilm = new ScienceFilm(scenario, montage, field, audience);
            }
            else {
                std::cin.ignore(); // Consume newline
                currentFilm = new ScienceFilm(scenario, montage, field);
            }
            films.push_back(currentFilm);

            std::cout << "Научный фильм создан и добавлен в список." << std::endl;
            break;
        }
        case 4:
            findProducer(currentFilm);
            break;
        case 5:
            filmMovie(currentFilm);
            break;
        case 6:
            if (currentFilm) {
                currentFilm->sounds(); // Вызов виртуальной функции для текущего фильма
            }
            else {
                std::cout << "Сначала нужно создать фильм." << std::endl;
            }
            break;
        case 7:
            if (currentFilm) {
                currentFilm->emotions();
            }
            else {
                std::cout << "Сначала нужно создать фильм." << std::endl;
            }
            break;
        case 8: {
            EntertainmentFilm* entFilm = dynamic_cast<EntertainmentFilm*>(currentFilm);
            if (entFilm) {
                entFilm->entertain();
            }
            else {
                std::cout << "Эта функция доступна только для развлекательных фильмов." << std::endl;
            }
            break;
        }
        case 9: {
            EntertainmentFilm* entFilm = dynamic_cast<EntertainmentFilm*>(currentFilm);
            if (entFilm) {
                entFilm->relax();
            }
            else {
                std::cout << "Эта функция доступна только для развлекательных фильмов." << std::endl;
            }
            break;
        }
        case 10: {
            ScienceFilm* sciFilm = dynamic_cast<ScienceFilm*>(currentFilm);
            if (sciFilm) {
                sciFilm->educate();
            }
            else {
                std::cout << "Эта функция доступна только для научных фильмов." << std::endl;
            }
            break;
        }
        case 11: {
            ScienceFilm* sciFilm = dynamic_cast<ScienceFilm*>(currentFilm);
            if (sciFilm) {
                sciFilm->motivate();
            }
            else {
                std::cout << "Эта функция доступна только для научных фильмов." << std::endl;
            }
            break;
        }
        case 12: {
            if (films.empty()) {
                std::cout << "Список фильмов пуст." << std::endl;
            }
            else {
                std::cout << "\nИнформация о всех фильмах:" << std::endl;
                for (Film* film : films) {
                    film->displayInfo();
                    std::cout << std::endl;
                }
            }
            break;
        }
        case 0:
            break;
        default:
            std::cout << "Неверный выбор. Пожалуйста, попробуйте снова." << std::endl;
        }
    } while (choice != 0);

    return 0;
}