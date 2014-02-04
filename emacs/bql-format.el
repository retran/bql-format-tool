; set your path to bql-format-tool.exe there
(setq bql-format-command "/cygdrive/d/code/bql-format-tool/src/bin/Debug/bql-format-tool.exe")

(defun bql-format (start end)
  "format bql command"
  (interactive "r")
  (setq formatted 
       (with-output-to-string
         (shell-command-on-region start end bql-format-command standard-output)))
  (delete-region start end)
  (goto-char start)
  (insert formatted))



