﻿using ScriptEngine.Machine.Contexts;

namespace osf
{
    [ContextClass ("КлЗначокОкнаСообщений", "ClMessageBoxIcon")]
    public class ClMessageBoxIcon : AutoContext<ClMessageBoxIcon>
    {
        private int m_none = (int)System.Windows.Forms.MessageBoxIcon.None; // 0 Окно сообщения не содержит символов.
        private int m_stop = (int)System.Windows.Forms.MessageBoxIcon.Stop; // 16 Окно сообщения содержит символ, состоящий из белого <B>X</B> в кружке с красным фоном.
        private int m_error = (int)System.Windows.Forms.MessageBoxIcon.Error; // 16 Окно сообщения содержит символ, состоящий из белого <B>X</B> в кружке с красным фоном.
        private int m_hand = (int)System.Windows.Forms.MessageBoxIcon.Hand; // 16 Окно сообщения содержит символ, состоящий из белого <B>X</B> в кружке с красным фоном.
        private int m_question = (int)System.Windows.Forms.MessageBoxIcon.Question; // 32 Окно сообщения содержит символ, состоящий из вопросительного знака в кружке.
        private int m_exclamation = (int)System.Windows.Forms.MessageBoxIcon.Exclamation; // 48 Окно сообщения содержит символ, состоящий из восклицательного знака в треугольнике с желтым фоном.
        private int m_warning = (int)System.Windows.Forms.MessageBoxIcon.Warning; // 48 Окно сообщения содержит символ, состоящий из восклицательного знака в треугольнике с желтым фоном.
        private int m_asterisk = (int)System.Windows.Forms.MessageBoxIcon.Asterisk; // 64 Окно сообщения содержит символ, состоящий из строчной буквы в кружке.
        private int m_information = (int)System.Windows.Forms.MessageBoxIcon.Information; // 64 Окно сообщения содержит символ, состоящий из строчной буквы в кружке.

        [ContextProperty("Вопрос", "Question")]
        public int Question
        {
        	get { return m_question; }
        }

        [ContextProperty("Восклицание", "Exclamation")]
        public int Exclamation
        {
        	get { return m_exclamation; }
        }

        [ContextProperty("Звездочка", "Asterisk")]
        public int Asterisk
        {
        	get { return m_asterisk; }
        }

        [ContextProperty("Информация", "Information")]
        public int Information
        {
        	get { return m_information; }
        }

        [ContextProperty("Остановка", "Stop")]
        public int Stop
        {
        	get { return m_stop; }
        }

        [ContextProperty("Отсутствие", "None")]
        public int None
        {
        	get { return m_none; }
        }

        [ContextProperty("Ошибка", "Error")]
        public int Error
        {
        	get { return m_error; }
        }

        [ContextProperty("Предупреждение", "Warning")]
        public int Warning
        {
        	get { return m_warning; }
        }

        [ContextProperty("Рука", "Hand")]
        public int Hand
        {
        	get { return m_hand; }
        }
    }
}
